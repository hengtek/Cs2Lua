require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("datablockdefine__cstring");

class(DataBlockDefine.StringArrayField) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DataBlockDefine.StringArrayField, "g_DataBlockDefine_StringArrayField", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.StringArrayField, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.StringArrayField.__cctor_called){
				return();
			}else{
				DataBlockDefine.StringArrayField.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		GetDataBlockId = deffunc(1)args(this){
			local(__method_ret_2377_8_2380_9);
			__method_ret_2377_8_2380_9 = getinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_DataBlockId");
			return(__method_ret_2377_8_2380_9);
		}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Struct, 0, true)];
		Init = deffunc(0)args(this){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_IsValid"), 2383_12_2384_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Release = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_IsValid"), System.Boolean, TypeKind.Struct), 2389_12_2390_23 ){
				return();
			};
			foreachlist(__foreach_ix_2391_12_2393_13, __foreach_exp_2391_12_2393_13, str, getinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_DataWrap"), DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.List_T, System.Collections.Generic.List_T, true){
				callinstance(str, DataBlockDefine.CString, "Release");
			};
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_DataWrap"), System.Collections.Generic.List_T, "Clear");
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 2395_12_2398_13 ){
				callstatic(DclApi, "free_array", getinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_DataBlockId"));
				setinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_DataBlockId", 0);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Attach = deffunc(0)args(this, dataBlockId){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_IsValid"), 2403_12_2404_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_DataBlockId", dataBlockId);
			local(len); len = callstatic(DclApi, "get_array_length", getinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_DataBlockId"));
			local(ix); ix = 0;
			while( execbinary("<", ix, typecast(len, System.UInt32, TypeKind.Struct), System.UInt32, System.UInt32, TypeKind.Struct, TypeKind.Struct) ){
				local(str); str = newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null);
				callinstance(str, DataBlockDefine.CString, "Attach", callstatic(DclApi, "get_array_element_uint64", getinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_DataBlockId"), ix));
				callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_DataWrap"), System.Collections.Generic.List_T, "Add", str);
			ix = execbinary("+", ix, 1, null, null, null, null);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(dataBlockId, System.UInt64, TypeKind.Struct, 0, true)];
		Detach = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_IsValid"), System.Boolean, TypeKind.Struct), 2416_12_2417_23 ){
				return();
			};
			foreachlist(__foreach_ix_2418_12_2420_13, __foreach_exp_2418_12_2420_13, str, getinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_DataWrap"), DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.List_T, System.Collections.Generic.List_T, true){
				callinstance(str, DataBlockDefine.CString, "Detach");
			};
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_DataWrap"), System.Collections.Generic.List_T, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		GetLength = deffunc(1)args(this){
			local(__method_ret_2425_8_2433_9);
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 2427_12_2432_13 ){
				__method_ret_2425_8_2433_9 = callstatic(DclApi, "get_array_length", getinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_DataBlockId"));
				return(__method_ret_2425_8_2433_9);
			}else{
				__method_ret_2425_8_2433_9 = 0;
				return(__method_ret_2425_8_2433_9);
			};
			return(null);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		GetData = deffunc(1)args(this, index){
			local(__method_ret_2434_8_2442_9);
			if( execbinary("&&", execbinary(">=", index, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), execbinary("<", index, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_DataWrap"), System.Collections.Generic.List_T, "Count"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 2436_12_2441_13 ){
				__method_ret_2434_8_2442_9 = getexterninstanceindexer(DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.List_T, getinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_DataWrap"), System.Collections.Generic.List_T, "get_Item", 1, index);
				return(__method_ret_2434_8_2442_9);
			}else{
				__method_ret_2434_8_2442_9 = null;
				return(__method_ret_2434_8_2442_9);
			};
			return(null);
		}options[needfuncinfo(false), rettype(return, DataBlockDefine.CString, TypeKind.Class, 0, false), paramtype(index, System.Int32, TypeKind.Struct, 0, true)];
		ctor = deffunc(0)args(this){
			callinstance(this, DataBlockDefine.StringArrayField, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "__ctor_called", true);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringArrayField, "m_DataWrap", newexternlist(System.Collections.Generic.List_T, "g_System_Collections_Generic_List_DataBlockDefine_CString", typeargs(DataBlockDefine.CString), typekinds(TypeKind.Class), "ctor", 0, literallist("g_System_Collections_Generic_List_DataBlockDefine_CString", typeargs(DataBlockDefine.CString), typekinds(TypeKind.Class))));
		}options[needfuncinfo(false)];
	};
	instance_fields {
		m_IsValid = false;
		m_DataBlockId = 0;
		m_DataWrap = null;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {
		"DataBlockDefine.IDataBlock";
	};

	class_info(TypeKind.Class, Accessibility.Public) {
	};
	method_info {
		GetDataBlockId(MethodKind.Ordinary, Accessibility.Public){
		};
		Init(MethodKind.Ordinary, Accessibility.Public){
		};
		Release(MethodKind.Ordinary, Accessibility.Public){
		};
		Attach(MethodKind.Ordinary, Accessibility.Public){
		};
		Detach(MethodKind.Ordinary, Accessibility.Public){
		};
		GetLength(MethodKind.Ordinary, Accessibility.Public){
		};
		GetData(MethodKind.Ordinary, Accessibility.Public){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
};



