require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(DataBlockDefine.DataBlockVector) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DataBlockDefine.DataBlockVector, "g_DataBlockDefine_DataBlockVector", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.DataBlockVector, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.DataBlockVector.__cctor_called){
				return();
			}else{
				DataBlockDefine.DataBlockVector.__cctor_called = true;
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
			local(__method_ret_1276_8_1279_9);
			__method_ret_1276_8_1279_9 = getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataBlockId");
			return(__method_ret_1276_8_1279_9);
		}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Struct, 0, true)];
		Init = deffunc(0)args(this){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_IsValid"), 1282_12_1283_23 ){
				return();
			};
			getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataBlockId") = callstatic(DclApi, "alloc_container", 2);
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataWrap"), System.Collections.Generic.List_T, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Release = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_IsValid"), System.Boolean, TypeKind.Struct), 1290_12_1291_23 ){
				return();
			};
			foreachlist(__foreach_ix_1292_12_1296_13, __foreach_exp_1292_12_1296_13, elem, getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataWrap"), DataBlockDefine.IDataBlock, TypeKind.Interface, System.Collections.Generic.List_T, System.Collections.Generic.List_T, true){
				if( execbinary("!=", null, elem, System.Object, System.Object, TypeKind.Class, TypeKind.Class), 1293_16_1295_17 ){
					callinterface(elem, DataBlockDefine.IDataBlock, "Release");
				};
			};
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataWrap"), System.Collections.Generic.List_T, "Clear");
			callstatic(DclApi, "free_container", getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataBlockId"));
			setinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Attach = deffunc(0)args(this, dataBlockId){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_IsValid"), 1304_12_1305_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataBlockId", dataBlockId);
			local(ct); ct = callstatic(DclApi, "container_get_size", dataBlockId);
			local(ix); ix = 0;
			while( execbinary("<", ix, ct, System.Int64, System.Int64, TypeKind.Struct, TypeKind.Struct) ){
				local(elem); elem = calldelegation(getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "OnNewDataBlock"), "DataBlockDefine.NewDataBlockDelegation.Invoke");
				callinterface(elem, DataBlockDefine.IDataBlock, "Attach", callstatic(DclApi, "uint64_vector_get_element", dataBlockId, typecast(ix, System.UInt64, TypeKind.Struct)));
				callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataWrap"), System.Collections.Generic.List_T, "Add", elem);
			ix = execbinary("+", ix, 1, null, null, null, null);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(dataBlockId, System.UInt64, TypeKind.Struct, 0, true)];
		Detach = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_IsValid"), System.Boolean, TypeKind.Struct), 1317_12_1318_23 ){
				return();
			};
			foreachlist(__foreach_ix_1319_12_1323_13, __foreach_exp_1319_12_1323_13, elem, getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataWrap"), DataBlockDefine.IDataBlock, TypeKind.Interface, System.Collections.Generic.List_T, System.Collections.Generic.List_T, true){
				if( execbinary("!=", null, elem, System.Object, System.Object, TypeKind.Class, TypeKind.Class), 1320_16_1322_17 ){
					callinterface(elem, DataBlockDefine.IDataBlock, "Detach");
				};
			};
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataWrap"), System.Collections.Generic.List_T, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Reserve = deffunc(0)args(this, space){
			setexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataWrap"), System.Collections.Generic.List_T, "Capacity", space);
			callstatic(DclApi, "container_reserve_space", getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataBlockId"), typecast(space, System.UInt64, TypeKind.Struct));
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(space, System.Int32, TypeKind.Struct, 0, true)];
		GetCount = deffunc(1)args(this){
			local(__method_ret_1334_8_1337_9);
			__method_ret_1334_8_1337_9 = getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataWrap"), System.Collections.Generic.List_T, "Count");
			return(__method_ret_1334_8_1337_9);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		GetData = deffunc(1)args(this, T, index){
			local(__method_ret_1338_8_1344_9);
			if( execbinary("&&", execbinary(">=", index, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), execbinary("<", index, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataWrap"), System.Collections.Generic.List_T, "Count"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 1340_12_1342_13 ){
				__method_ret_1338_8_1344_9 = typecast(getexterninstanceindexer(DataBlockDefine.IDataBlock, TypeKind.Interface, System.Collections.Generic.List_T, getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataWrap"), System.Collections.Generic.List_T, "get_Item", 1, index), T, TypeKind.TypeParameter);
				return(__method_ret_1338_8_1344_9);
			};
			__method_ret_1338_8_1344_9 = null;
			return(__method_ret_1338_8_1344_9);
		}options[needfuncinfo(false), rettype(T, DataBlockDefine.IDataBlock, TypeKind.TypeParameter, 0, false), paramtype(T, DataBlockDefine.IDataBlock, TypeKind.TypeParameter, 0, false), paramtype(index, System.Int32, TypeKind.Struct, 0, true)];
		SetData = deffunc(0)args(this, index, data){
			if( execbinary("&&", execbinary(">=", index, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), execbinary("<", index, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataWrap"), System.Collections.Generic.List_T, "Count"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 1347_12_1350_13 ){
				setexterninstanceindexer(DataBlockDefine.IDataBlock, TypeKind.Interface, System.Collections.Generic.List_T, getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataWrap"), System.Collections.Generic.List_T, "set_Item", 2, index, data);
				callstatic(DclApi, "uint64_vector_set_element", getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataBlockId"), typecast(index, System.UInt64, TypeKind.Struct), callinterface(data, DataBlockDefine.IDataBlock, "GetDataBlockId"));
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(index, System.Int32, TypeKind.Struct, 0, true), paramtype(data, DataBlockDefine.IDataBlock, TypeKind.Interface, 0, false)];
		IndexOf = deffunc(1)args(this, data){
			local(__method_ret_1352_8_1355_9);
			__method_ret_1352_8_1355_9 = callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataWrap"), System.Collections.Generic.List_T, "IndexOf__T", data);
			return(__method_ret_1352_8_1355_9);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true), paramtype(data, DataBlockDefine.IDataBlock, TypeKind.Interface, 0, false)];
		GetLast = deffunc(1)args(this, T){
			local(__method_ret_1356_8_1359_9);
			__method_ret_1356_8_1359_9 = callinstance(this, DataBlockDefine.DataBlockVector, "GetData", T, execbinary("-", callinstance(this, DataBlockDefine.DataBlockVector, "GetCount"), 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
			return(__method_ret_1356_8_1359_9);
		}options[needfuncinfo(false), rettype(T, DataBlockDefine.IDataBlock, TypeKind.TypeParameter, 0, false), paramtype(T, DataBlockDefine.IDataBlock, TypeKind.TypeParameter, 0, false)];
		AddLast = deffunc(0)args(this, data){
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataWrap"), System.Collections.Generic.List_T, "Add", data);
			callstatic(DclApi, "uint64_vector_push_back", getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataBlockId"), callinterface(data, DataBlockDefine.IDataBlock, "GetDataBlockId"));
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(data, DataBlockDefine.IDataBlock, TypeKind.Interface, 0, false)];
		RemoveLast = deffunc(0)args(this){
			if( execbinary(">", getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataWrap"), System.Collections.Generic.List_T, "Count"), 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), 1367_12_1370_13 ){
				callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataWrap"), System.Collections.Generic.List_T, "RemoveAt", execbinary("-", getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataWrap"), System.Collections.Generic.List_T, "Count"), 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
				callstatic(DclApi, "uint64_vector_pop_back", getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataBlockId"));
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Remove = deffunc(0)args(this, data){
			local(index); index = callinstance(this, DataBlockDefine.DataBlockVector, "IndexOf", data);
			callinstance(this, DataBlockDefine.DataBlockVector, "RemoveAt", index);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(data, DataBlockDefine.IDataBlock, TypeKind.Interface, 0, false)];
		RemoveAt = deffunc(0)args(this, index){
			if( execbinary("&&", execbinary(">=", index, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), execbinary("<", index, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataWrap"), System.Collections.Generic.List_T, "Count"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 1379_12_1382_13 ){
				callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataWrap"), System.Collections.Generic.List_T, "RemoveAt", index);
				callstatic(DclApi, "uint64_vector_erase", getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataBlockId"), typecast(index, System.UInt64, TypeKind.Struct));
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(index, System.Int32, TypeKind.Struct, 0, true)];
		Clear = deffunc(0)args(this){
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataWrap"), System.Collections.Generic.List_T, "Clear");
			callstatic(DclApi, "container_clear", getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataBlockId"));
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		ctor = deffunc(0)args(this){
			callinstance(this, DataBlockDefine.DataBlockVector, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "__ctor_called", true);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.DataBlockVector, "m_DataWrap", newexternlist(System.Collections.Generic.List_T, "g_System_Collections_Generic_List_DataBlockDefine_IDataBlock", typeargs(DataBlockDefine.IDataBlock), typekinds(TypeKind.Interface), "ctor", 0, literallist("g_System_Collections_Generic_List_DataBlockDefine_IDataBlock", typeargs(DataBlockDefine.IDataBlock), typekinds(TypeKind.Interface))));
		}options[needfuncinfo(false)];
	};
	instance_fields {
		OnNewDataBlock = null;
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
		Reserve(MethodKind.Ordinary, Accessibility.Public){
		};
		GetCount(MethodKind.Ordinary, Accessibility.Public){
		};
		GetData(MethodKind.Ordinary, Accessibility.Public){
			generic(true);
		};
		SetData(MethodKind.Ordinary, Accessibility.Public){
		};
		IndexOf(MethodKind.Ordinary, Accessibility.Public){
		};
		GetLast(MethodKind.Ordinary, Accessibility.Public){
			generic(true);
		};
		AddLast(MethodKind.Ordinary, Accessibility.Public){
		};
		RemoveLast(MethodKind.Ordinary, Accessibility.Public){
		};
		Remove(MethodKind.Ordinary, Accessibility.Public){
		};
		RemoveAt(MethodKind.Ordinary, Accessibility.Public){
		};
		Clear(MethodKind.Ordinary, Accessibility.Public){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
};



