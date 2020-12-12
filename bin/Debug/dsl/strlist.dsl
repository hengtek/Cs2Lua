require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(StrList, System.Collections.Generic.List_T) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(StrList, typeargs(), typekinds(), "ctor", null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(StrList, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(StrList.__cctor_called){
				return();
			}else{
				StrList.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = deffunc(0)args(this){
			callinstance(getinstance(SymbolKind.Field, this, StrList, "base"), StrList, "ctor");
			callinstance(this, StrList, "__ctor");
			return(this);
		}options[needfuncinfo(false)],
		ctor__Int32 = deffunc(0)args(this, c){
			callinstance(getinstance(SymbolKind.Field, this, StrList, "base"), StrList, "ctor__Int32", c);
			callinstance(this, StrList, "__ctor");
			return(this);
		}options[needfuncinfo(false)],
		ctor__ICollection_1_T = deffunc(0)args(this, coll){
			callinstance(getinstance(SymbolKind.Field, this, StrList, "base"), StrList, "ctor__IEnumerable_1_Object", coll);
			callinstance(this, StrList, "__ctor");
			return(this);
		}options[needfuncinfo(false)],
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, StrList, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, StrList, "__ctor_called", true);
			};
		}options[needfuncinfo(false)];
	};
	instance_fields {
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {
		"System.Collections.Generic.IList_T";
		"System.Collections.Generic.ICollection_T";
		"System.Collections.IList";
		"System.Collections.ICollection";
		"System.Collections.Generic.IReadOnlyList_T";
		"System.Collections.Generic.IReadOnlyCollection_T";
		"System.Collections.Generic.IEnumerable_T";
		"System.Collections.IEnumerable";
	};

	class_info(TypeKind.Class, Accessibility.Public) {
	};
	method_info {
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
		ctor__Int32(MethodKind.Constructor, Accessibility.Public){
		};
		ctor__ICollection_1_T(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {};
};


