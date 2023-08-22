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
    
    // Role: HANDLER
    public abstract unsafe partial class CefContextMenuHandler
    {
        private static Dictionary<IntPtr, CefContextMenuHandler> _roots = new Dictionary<IntPtr, CefContextMenuHandler>();
        
        private int _refct;
        private cef_context_menu_handler_t* _self;
        
        protected object SyncRoot { get { return this; } }
        
        private cef_context_menu_handler_t.add_ref_delegate _ds0;
        private cef_context_menu_handler_t.release_delegate _ds1;
        private cef_context_menu_handler_t.has_one_ref_delegate _ds2;
        private cef_context_menu_handler_t.has_at_least_one_ref_delegate _ds3;
        private cef_context_menu_handler_t.on_before_context_menu_delegate _ds4;
        private cef_context_menu_handler_t.run_context_menu_delegate _ds5;
        private cef_context_menu_handler_t.on_context_menu_command_delegate _ds6;
        private cef_context_menu_handler_t.on_context_menu_dismissed_delegate _ds7;
        private cef_context_menu_handler_t.run_quick_menu_delegate _ds8;
        private cef_context_menu_handler_t.on_quick_menu_command_delegate _ds9;
        private cef_context_menu_handler_t.on_quick_menu_dismissed_delegate _dsa;
        
        protected CefContextMenuHandler()
        {
            _self = cef_context_menu_handler_t.Alloc();
        
            _ds0 = new cef_context_menu_handler_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_context_menu_handler_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_context_menu_handler_t.has_one_ref_delegate(has_one_ref);
            _self->_base._has_one_ref = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_context_menu_handler_t.has_at_least_one_ref_delegate(has_at_least_one_ref);
            _self->_base._has_at_least_one_ref = Marshal.GetFunctionPointerForDelegate(_ds3);
            _ds4 = new cef_context_menu_handler_t.on_before_context_menu_delegate(on_before_context_menu);
            _self->_on_before_context_menu = Marshal.GetFunctionPointerForDelegate(_ds4);
            _ds5 = new cef_context_menu_handler_t.run_context_menu_delegate(run_context_menu);
            _self->_run_context_menu = Marshal.GetFunctionPointerForDelegate(_ds5);
            _ds6 = new cef_context_menu_handler_t.on_context_menu_command_delegate(on_context_menu_command);
            _self->_on_context_menu_command = Marshal.GetFunctionPointerForDelegate(_ds6);
            _ds7 = new cef_context_menu_handler_t.on_context_menu_dismissed_delegate(on_context_menu_dismissed);
            _self->_on_context_menu_dismissed = Marshal.GetFunctionPointerForDelegate(_ds7);
            _ds8 = new cef_context_menu_handler_t.run_quick_menu_delegate(run_quick_menu);
            _self->_run_quick_menu = Marshal.GetFunctionPointerForDelegate(_ds8);
            _ds9 = new cef_context_menu_handler_t.on_quick_menu_command_delegate(on_quick_menu_command);
            _self->_on_quick_menu_command = Marshal.GetFunctionPointerForDelegate(_ds9);
            _dsa = new cef_context_menu_handler_t.on_quick_menu_dismissed_delegate(on_quick_menu_dismissed);
            _self->_on_quick_menu_dismissed = Marshal.GetFunctionPointerForDelegate(_dsa);
        }
        
        ~CefContextMenuHandler()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_context_menu_handler_t.Free(_self);
                _self = null;
            }
        }
        
        private void add_ref(cef_context_menu_handler_t* self)
        {
            lock (SyncRoot)
            {
                var result = ++_refct;
                if (result == 1)
                {
                    lock (_roots) { _roots.Add((IntPtr)_self, this); }
                }
            }
        }
        
        private int release(cef_context_menu_handler_t* self)
        {
            lock (SyncRoot)
            {
                var result = --_refct;
                if (result == 0)
                {
                    lock (_roots) { _roots.Remove((IntPtr)_self); }
                    return 1;
                }
                return 0;
            }
        }
        
        private int has_one_ref(cef_context_menu_handler_t* self)
        {
            lock (SyncRoot) { return _refct == 1 ? 1 : 0; }
        }
        
        private int has_at_least_one_ref(cef_context_menu_handler_t* self)
        {
            lock (SyncRoot) { return _refct != 0 ? 1 : 0; }
        }
        
        internal cef_context_menu_handler_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_context_menu_handler_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}
