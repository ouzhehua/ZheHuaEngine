// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'
// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Extensions/RenderShadow/RenderShadowProjector" {
	Properties {
		_Color("_ShadowColor", COLOR) = (0,0,0,0)
		_Strength("_Strength", Range(0, 0.2)) = 0.1
	}
	Subshader {
		Tags {"Queue"="Transparent"}
		Pass {
			ZWrite Off
			Blend SrcAlpha OneMinusSrcAlpha
			Offset -1, -1
 
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"
			struct v2f {
				float4 uvShadow : TEXCOORD0;
				float4 pos : SV_POSITION;
			};
			
			uniform float4x4 ShadowMatrix;
			
			v2f vert (appdata_base v)
			{
				v2f o;
				o.pos = UnityObjectToClipPos (v.vertex);
				float4x4 matWVP = mul (ShadowMatrix, unity_ObjectToWorld);
				o.uvShadow = mul(matWVP, v.vertex);        
				return o;
			}
			
			sampler2D _ShadowTex;
			fixed4 _Color;
			float _Strength;

			fixed4 frag (v2f i) : SV_Target
			{
				half2 uv = i.uvShadow.xy / i.uvShadow.w * 0.5 + 0.5;

				#if UNITY_UV_STARTS_AT_TOP
                	uv.y = 1 - uv.y;
                #endif

 				fixed4 res = fixed4(_Color.r, _Color.g, _Color.b, 0);

 				float pad = 1600;
 				fixed4 texS = tex2D(_ShadowTex, uv);
 				if(texS.a > 0)
 				{
 					res.a += _Strength;
 				}

 				texS = tex2D(_ShadowTex, uv + half2(-0.94201624/pad, -0.39906216/pad));
 				if(texS.a > 0)
 				{
 					res.a += _Strength;
 				}
 				
 				texS = tex2D(_ShadowTex, uv + half2(0.94558609/pad, -0.76890725/pad));
 				if(texS.a > 0)
 				{
 					res.a += _Strength;
 				}
 				
 				texS = tex2D(_ShadowTex, uv + half2(-0.094184101/pad, -0.92938870/pad));
 				if(texS.a > 0)
 				{
 					res.a += _Strength;
 				}

 				texS = tex2D(_ShadowTex, uv + half2(0.34495938/pad, 0.29387760/pad));
 				if(texS.a > 0)
 				{
 					res.a += _Strength;
 				}

				return res;
			}
			ENDCG
		}
	}
}
