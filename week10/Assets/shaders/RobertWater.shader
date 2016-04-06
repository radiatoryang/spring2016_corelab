Shader "RobertAwesomeShaders/RobertWater"
{
	// "Properties" are like the public variables of a shader
	Properties
	{
		// _MainTex is the name of the variable
		// "Texture" is the text label in Unity inspector
		// 2D is the actual variable type
		// "white" tells Unity to automatically use white if there's no texture
		_MainTex ("Texture", 2D) = "white" {}
		_WaveHeight ( "Wave Height (beyonce is great)", Float ) = 1.0

	}
	// "SubShader" is where your shader code actually goes
	SubShader
	{
		// "Opaque" means "not transparent", which is the fastest thing to draw
		Tags { "RenderType"="Opaque" }
		// "LOD" means "level of detail"
		LOD 100

		// "Pass" is like 1 draw call, kind of
		// ideally, your shaders are "single-pass", just 1 pass
		Pass
		{
			// "CGPROGRAM" means the start of our actual shader code
			CGPROGRAM
			// "#pragma" is Greek for "action"
			// pragma basically means "special instruction"
			#pragma vertex vert
			#pragma fragment frag
			// make fog work
			#pragma multi_compile_fog

			// "cginc" means CG include, it's another piece of shader code
			#include "UnityCG.cginc"

			// "struct" is like a simpler version of a class, usually for data
			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			// vertex 2 fragment
			struct v2f
			{
				float2 uv : TEXCOORD0;
				UNITY_FOG_COORDS(1)
				float4 vertex : SV_POSITION;
			};

			// 2 variables...
			// declare a "twin" of your public Property (from top of shader)
			sampler2D _MainTex;
			// "ST" stands for Scale / Translate, it's Tiling / Offset
			float4 _MainTex_ST;

			float _WaveHeight; // will automatically get value from Properties
			
			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = mul(UNITY_MATRIX_MVP, v.vertex);
				o.vertex += float4(0,sin( (_Time.y + o.vertex.z) * 2 ) * _WaveHeight,0,0);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				UNITY_TRANSFER_FOG(o,o.vertex);
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{
				// sample the texture
				fixed4 col = tex2D(_MainTex, i.uv + fixed2( _Time.y * 0.2, 0) );
				// apply fog
				UNITY_APPLY_FOG(i.fogCoord, col);
				return col;
			}
			ENDCG // shader code ends
		}
	}
}
