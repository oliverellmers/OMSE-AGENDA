// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33042,y:32693,varname:node_3138,prsc:2|emission-5760-OUT,alpha-3108-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:31853,y:32683,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_7241,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.07843138,c2:0.3921569,c3:0.7843137,c4:1;n:type:ShaderForge.SFN_Tex2d,id:2126,x:31684,y:32994,ptovrint:False,ptlb:Texture,ptin:_Texture,varname:node_2126,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:113ed537835ecc04b8ad9efffe9d3aaa,ntxv:0,isnm:False|UVIN-8535-UVOUT;n:type:ShaderForge.SFN_Multiply,id:5164,x:32045,y:32683,varname:node_5164,prsc:2|A-7241-RGB,B-2126-RGB;n:type:ShaderForge.SFN_TexCoord,id:5911,x:30665,y:32975,varname:node_5911,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_OneMinus,id:6251,x:30855,y:33047,varname:node_6251,prsc:2|IN-5911-U;n:type:ShaderForge.SFN_Append,id:4059,x:31019,y:32997,varname:node_4059,prsc:2|A-6251-OUT,B-5911-V;n:type:ShaderForge.SFN_Multiply,id:3967,x:31328,y:33004,varname:node_3967,prsc:2|A-4059-OUT,B-8258-OUT;n:type:ShaderForge.SFN_Vector2,id:1168,x:30855,y:33242,varname:node_1168,prsc:2,v1:0.5,v2:0.5;n:type:ShaderForge.SFN_Lerp,id:8859,x:32336,y:32844,varname:node_8859,prsc:2|A-7915-RGB,B-5164-OUT,T-2126-A;n:type:ShaderForge.SFN_Color,id:7915,x:32045,y:32860,ptovrint:False,ptlb:Background,ptin:_Background,varname:node_7915,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_SwitchProperty,id:3108,x:32188,y:33166,ptovrint:False,ptlb:OpacitySwitch,ptin:_OpacitySwitch,varname:node_3108,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-8679-OUT,B-2126-A;n:type:ShaderForge.SFN_Vector1,id:8679,x:32004,y:33089,varname:node_8679,prsc:2,v1:1;n:type:ShaderForge.SFN_Append,id:8258,x:31129,y:33233,varname:node_8258,prsc:2|A-3252-OUT,B-3937-OUT;n:type:ShaderForge.SFN_Slider,id:3252,x:30828,y:33369,ptovrint:False,ptlb:Scale_U,ptin:_Scale_U,varname:node_3252,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:4;n:type:ShaderForge.SFN_Slider,id:3937,x:30828,y:33481,ptovrint:False,ptlb:Scale_V,ptin:_Scale_V,varname:_Scale_U_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:4;n:type:ShaderForge.SFN_Panner,id:8535,x:31506,y:32994,varname:node_8535,prsc:2,spu:0,spv:-0.25|UVIN-3967-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:8470,x:31581,y:33425,varname:node_8470,prsc:2;n:type:ShaderForge.SFN_ViewPosition,id:5584,x:31581,y:33562,varname:node_5584,prsc:2;n:type:ShaderForge.SFN_Distance,id:7710,x:31905,y:33467,varname:node_7710,prsc:2|A-8470-XYZ,B-5584-XYZ;n:type:ShaderForge.SFN_Divide,id:7383,x:32089,y:33467,varname:node_7383,prsc:2|A-7710-OUT,B-2870-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2870,x:31905,y:33619,ptovrint:False,ptlb:TransitionDistance,ptin:_TransitionDistance,varname:node_2870,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:4;n:type:ShaderForge.SFN_Power,id:6810,x:32263,y:33467,varname:node_6810,prsc:2|VAL-7383-OUT,EXP-3014-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3014,x:32089,y:33665,ptovrint:False,ptlb:Falloff,ptin:_Falloff,varname:node_3014,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:500;n:type:ShaderForge.SFN_Clamp01,id:1307,x:32447,y:33467,varname:node_1307,prsc:2|IN-6810-OUT;n:type:ShaderForge.SFN_Lerp,id:5760,x:32573,y:33243,varname:node_5760,prsc:2|A-8859-OUT,B-7915-RGB,T-1307-OUT;proporder:7241-2126-7915-3108-3252-3937-2870-3014;pass:END;sub:END;*/

Shader "Shader Forge/SF_WormholeInside" {
    Properties {
        _Color ("Color", Color) = (0.07843138,0.3921569,0.7843137,1)
        _Texture ("Texture", 2D) = "white" {}
        _Background ("Background", Color) = (0.5,0.5,0.5,1)
        [MaterialToggle] _OpacitySwitch ("OpacitySwitch", Float ) = 1
        _Scale_U ("Scale_U", Range(0, 4)) = 0.5
        _Scale_V ("Scale_V", Range(0, 4)) = 0.5
        _TransitionDistance ("TransitionDistance", Float ) = 4
        _Falloff ("Falloff", Float ) = 500
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x 
            #pragma target 3.0
            uniform float4 _Color;
            uniform sampler2D _Texture; uniform float4 _Texture_ST;
            uniform float4 _Background;
            uniform fixed _OpacitySwitch;
            uniform float _Scale_U;
            uniform float _Scale_V;
            uniform float _TransitionDistance;
            uniform float _Falloff;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float4 node_9858 = _Time;
                float2 node_8535 = ((float2((1.0 - i.uv0.r),i.uv0.g)*float2(_Scale_U,_Scale_V))+node_9858.g*float2(0,-0.25));
                float4 _Texture_var = tex2D(_Texture,TRANSFORM_TEX(node_8535, _Texture));
                float3 emissive = lerp(lerp(_Background.rgb,(_Color.rgb*_Texture_var.rgb),_Texture_var.a),_Background.rgb,saturate(pow((distance(i.posWorld.rgb,_WorldSpaceCameraPos)/_TransitionDistance),_Falloff)));
                float3 finalColor = emissive;
                return fixed4(finalColor,lerp( 1.0, _Texture_var.a, _OpacitySwitch ));
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
