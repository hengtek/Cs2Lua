﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_UI_Dropdown_OptionData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.UI.Dropdown.OptionData o;
			o=new UnityEngine.UI.Dropdown.OptionData();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor__String_s(IntPtr l) {
		try {
			UnityEngine.UI.Dropdown.OptionData o;
			System.String a1;
			checkType(l,1,out a1);
			o=new UnityEngine.UI.Dropdown.OptionData(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor__Sprite_s(IntPtr l) {
		try {
			UnityEngine.UI.Dropdown.OptionData o;
			UnityEngine.Sprite a1;
			checkType(l,1,out a1);
			o=new UnityEngine.UI.Dropdown.OptionData(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor__String__Sprite_s(IntPtr l) {
		try {
			UnityEngine.UI.Dropdown.OptionData o;
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Sprite a2;
			checkType(l,2,out a2);
			o=new UnityEngine.UI.Dropdown.OptionData(a1,a2);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_text(IntPtr l) {
		try {
			UnityEngine.UI.Dropdown.OptionData self=(UnityEngine.UI.Dropdown.OptionData)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.text);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_text(IntPtr l) {
		try {
			UnityEngine.UI.Dropdown.OptionData self=(UnityEngine.UI.Dropdown.OptionData)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.text=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_image(IntPtr l) {
		try {
			UnityEngine.UI.Dropdown.OptionData self=(UnityEngine.UI.Dropdown.OptionData)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.image);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_image(IntPtr l) {
		try {
			UnityEngine.UI.Dropdown.OptionData self=(UnityEngine.UI.Dropdown.OptionData)checkSelf(l);
			UnityEngine.Sprite v;
			checkType(l,2,out v);
			self.image=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Dropdown.OptionData");
		addMember(l,ctor_s);
		addMember(l,ctor__String_s);
		addMember(l,ctor__Sprite_s);
		addMember(l,ctor__String__Sprite_s);
		addMember(l,"text",get_text,set_text,true);
		addMember(l,"image",get_image,set_image,true);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.Dropdown.OptionData));
	}
}
