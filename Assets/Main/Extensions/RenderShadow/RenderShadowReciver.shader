// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Extensions/RenderShadow/RenderShadowReciver" {
	Properties {
		_Color("_ShadowColor", COLOR) = (0,0,0,0)
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
				float4 uv : TEXCOORD0;
				float4 pos : SV_POSITION;
			};
			
			fixed4 _Color;
			
			v2f vert (appdata_base v)
			{
				v2f o;
				o.pos = UnityObjectToClipPos (v.vertex);
				o.uv = v.texcoord;
				return o;
			}

			fixed4 frag (v2f i) : SV_Target
			{
				return _Color;
			}
			ENDCG
		}
	}
}
