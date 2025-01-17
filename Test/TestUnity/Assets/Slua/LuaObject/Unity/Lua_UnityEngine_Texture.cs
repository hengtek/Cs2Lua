﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Texture : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetNativeTexturePtr(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			var ret=self.GetNativeTexturePtr();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IncrementUpdateCount(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			self.IncrementUpdateCount();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalAnisotropicFilteringLimits_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Texture.SetGlobalAnisotropicFilteringLimits(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetStreamingTextureMaterialDebugProperties_s(IntPtr l) {
		try {
			UnityEngine.Texture.SetStreamingTextureMaterialDebugProperties();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_masterTextureLimit(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture.masterTextureLimit);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_masterTextureLimit(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.Texture.masterTextureLimit=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_anisotropicFiltering(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.Texture.anisotropicFiltering);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_anisotropicFiltering(IntPtr l) {
		try {
			UnityEngine.AnisotropicFiltering v;
			checkEnum(l,2,out v);
			UnityEngine.Texture.anisotropicFiltering=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_width(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.width);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_width(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.width=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_height(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.height);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_height(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.height=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_dimension(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.dimension);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_dimension(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			UnityEngine.Rendering.TextureDimension v;
			checkEnum(l,2,out v);
			self.dimension=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isReadable(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isReadable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_wrapMode(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.wrapMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_wrapMode(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			UnityEngine.TextureWrapMode v;
			checkEnum(l,2,out v);
			self.wrapMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_wrapModeU(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.wrapModeU);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_wrapModeU(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			UnityEngine.TextureWrapMode v;
			checkEnum(l,2,out v);
			self.wrapModeU=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_wrapModeV(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.wrapModeV);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_wrapModeV(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			UnityEngine.TextureWrapMode v;
			checkEnum(l,2,out v);
			self.wrapModeV=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_wrapModeW(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.wrapModeW);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_wrapModeW(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			UnityEngine.TextureWrapMode v;
			checkEnum(l,2,out v);
			self.wrapModeW=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_filterMode(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.filterMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_filterMode(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			UnityEngine.FilterMode v;
			checkEnum(l,2,out v);
			self.filterMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_anisoLevel(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.anisoLevel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_anisoLevel(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.anisoLevel=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_mipMapBias(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mipMapBias);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mipMapBias(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.mipMapBias=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lowDetail(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lowDetail);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lowDetail(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.lowDetail=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_customFlag(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.customFlag);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_customFlag(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.customFlag=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_customValue(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.customValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_customValue(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.customValue=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lodBias(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lodBias);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lodBias(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.lodBias=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_texelSize(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.texelSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_updateCount(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.updateCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_imageContentsHash(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.imageContentsHash);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_imageContentsHash(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			UnityEngine.Hash128 v;
			checkValueType(l,2,out v);
			self.imageContentsHash=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_totalTextureMemory(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture.totalTextureMemory);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_desiredTextureMemory(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture.desiredTextureMemory);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_targetTextureMemory(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture.targetTextureMemory);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_currentTextureMemory(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture.currentTextureMemory);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_nonStreamingTextureMemory(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture.nonStreamingTextureMemory);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_streamingMipmapUploadCount(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture.streamingMipmapUploadCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_streamingRendererCount(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture.streamingRendererCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_streamingTextureCount(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture.streamingTextureCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_nonStreamingTextureCount(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture.nonStreamingTextureCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_streamingTexturePendingLoadCount(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture.streamingTexturePendingLoadCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_streamingTextureLoadingCount(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture.streamingTextureLoadingCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_streamingTextureForceLoadAll(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture.streamingTextureForceLoadAll);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_streamingTextureForceLoadAll(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.Texture.streamingTextureForceLoadAll=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_streamingTextureDiscardUnusedMips(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture.streamingTextureDiscardUnusedMips);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_streamingTextureDiscardUnusedMips(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.Texture.streamingTextureDiscardUnusedMips=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Texture");
		addMember(l,GetNativeTexturePtr);
		addMember(l,IncrementUpdateCount);
		addMember(l,SetGlobalAnisotropicFilteringLimits_s);
		addMember(l,SetStreamingTextureMaterialDebugProperties_s);
		addMember(l,"masterTextureLimit",get_masterTextureLimit,set_masterTextureLimit,false);
		addMember(l,"anisotropicFiltering",get_anisotropicFiltering,set_anisotropicFiltering,false);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"dimension",get_dimension,set_dimension,true);
		addMember(l,"isReadable",get_isReadable,null,true);
		addMember(l,"wrapMode",get_wrapMode,set_wrapMode,true);
		addMember(l,"wrapModeU",get_wrapModeU,set_wrapModeU,true);
		addMember(l,"wrapModeV",get_wrapModeV,set_wrapModeV,true);
		addMember(l,"wrapModeW",get_wrapModeW,set_wrapModeW,true);
		addMember(l,"filterMode",get_filterMode,set_filterMode,true);
		addMember(l,"anisoLevel",get_anisoLevel,set_anisoLevel,true);
		addMember(l,"mipMapBias",get_mipMapBias,set_mipMapBias,true);
		addMember(l,"lowDetail",get_lowDetail,set_lowDetail,true);
		addMember(l,"customFlag",get_customFlag,set_customFlag,true);
		addMember(l,"customValue",get_customValue,set_customValue,true);
		addMember(l,"lodBias",get_lodBias,set_lodBias,true);
		addMember(l,"texelSize",get_texelSize,null,true);
		addMember(l,"updateCount",get_updateCount,null,true);
		addMember(l,"imageContentsHash",get_imageContentsHash,set_imageContentsHash,true);
		addMember(l,"totalTextureMemory",get_totalTextureMemory,null,false);
		addMember(l,"desiredTextureMemory",get_desiredTextureMemory,null,false);
		addMember(l,"targetTextureMemory",get_targetTextureMemory,null,false);
		addMember(l,"currentTextureMemory",get_currentTextureMemory,null,false);
		addMember(l,"nonStreamingTextureMemory",get_nonStreamingTextureMemory,null,false);
		addMember(l,"streamingMipmapUploadCount",get_streamingMipmapUploadCount,null,false);
		addMember(l,"streamingRendererCount",get_streamingRendererCount,null,false);
		addMember(l,"streamingTextureCount",get_streamingTextureCount,null,false);
		addMember(l,"nonStreamingTextureCount",get_nonStreamingTextureCount,null,false);
		addMember(l,"streamingTexturePendingLoadCount",get_streamingTexturePendingLoadCount,null,false);
		addMember(l,"streamingTextureLoadingCount",get_streamingTextureLoadingCount,null,false);
		addMember(l,"streamingTextureForceLoadAll",get_streamingTextureForceLoadAll,set_streamingTextureForceLoadAll,false);
		addMember(l,"streamingTextureDiscardUnusedMips",get_streamingTextureDiscardUnusedMips,set_streamingTextureDiscardUnusedMips,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Texture),typeof(UnityEngine.Object));
	}
}
