﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefNavigationEntry : IDisposable
    {
        internal static CefNavigationEntry FromNative(cef_navigation_entry_t* ptr)
        {
            return new CefNavigationEntry(ptr);
        }
        
        internal static CefNavigationEntry FromNativeOrNull(cef_navigation_entry_t* ptr)
        {
            if (ptr == null) return null;
            return new CefNavigationEntry(ptr);
        }
        
        private cef_navigation_entry_t* _self;
        
        private CefNavigationEntry(cef_navigation_entry_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefNavigationEntry()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
            GC.SuppressFinalize(this);
        }
        
        internal void AddRef()
        {
            cef_navigation_entry_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_navigation_entry_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_navigation_entry_t.has_one_ref(_self) != 0; }
        }
        
        internal cef_navigation_entry_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
