Shader "PocketPlaces/OutLine&Fresnel"
{
    Properties
    {
        _Color ("Cor Albedo", Color) = (1,1,1,1)
        _MainTex ("Albedo", 2D) = "white" {}
		_Bump ("Normal map", 2D) = "bump" {}
        _Metallic ("Metallic", Range(0,1.5)) = 0.0
		_Glossiness ("Smoothness", Range(0,1.5)) = 0.5

	  [PerRendererData] _OutlineColor ("Cor Outline", Color) = (0, 0, 0, 0)
       _OutlineWidth ("Largura Outline", Range(0, 5)) = 0.03

		//-----------------------------------------
	   [PerRendererData] _MyColor ("Cor brilho", Color) = (0,0,0,0) 
	 	_Shininess ("Nivel brilho", Range (0.01, 3)) = 1
		
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
       
        #pragma surface surf Standard fullforwardshadows

       
        #pragma target 3.0

        sampler2D _MainTex;
		//-------------
		sampler2D _Bump;
		float _Shininess;
		fixed4 _MyColor; 
		
		

        struct Input
        {
            float2 uv_MainTex;
			float4 color : COLOR;
			//--------------------
			
			float2 uv_Bump;
			float3 viewDir;
        };

        half _Glossiness;
        half _Metallic;
        fixed4 _Color;

        UNITY_INSTANCING_BUFFER_START(Props)
            // put more per-instance properties here
        UNITY_INSTANCING_BUFFER_END(Props)

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
           
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;

			o.Normal = UnpackNormal(tex2D(_Bump,IN.uv_Bump));
			half factor= dot(normalize(IN.viewDir),o.Normal);

			o.Albedo = c.rgb ;//+ (_MyColor*(_Shininess-factor*_Shininess));
			o.Emission =  (_MyColor*(_Shininess-factor*_Shininess));
           
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;
            o.Alpha = c.a;
        }
        ENDCG

		Pass 
	  {

            Cull Front

            CGPROGRAM

            #pragma vertex VertexProgram
            #pragma fragment FragmentProgram

            half _OutlineWidth;

           float4 VertexProgram(float4 position : POSITION, float3 normal : NORMAL) : SV_POSITION 
	     {
           float4 clipPosition = UnityObjectToClipPos(position);
           float3 clipNormal = mul((float3x3) UNITY_MATRIX_VP, mul((float3x3) UNITY_MATRIX_M, normal));

		   float2 offset = normalize(clipNormal.xy) / _ScreenParams.xy * _OutlineWidth * clipPosition.w * 2 ;
           clipPosition.xy += offset;


           /*clipPosition.xyz += normalize(clipNormal) * _OutlineWidth;*/

           return clipPosition;
		 }

            half4 _OutlineColor;

            half4 FragmentProgram() : SV_TARGET 
			{
                return _OutlineColor;
            }

            ENDCG

       }
	   //By: Lucas Gabriel



    }
    FallBack "Diffuse"
}
