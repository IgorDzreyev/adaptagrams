/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.36
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.adaptagrams.cola {

using System;
using System.Runtime.InteropServices;

public class UnsatisfiableConstraintInfo : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UnsatisfiableConstraintInfo(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UnsatisfiableConstraintInfo obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnsatisfiableConstraintInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        colaPINVOKE.delete_UnsatisfiableConstraintInfo(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public UnsatisfiableConstraintInfo(SWIGTYPE_p_vpsc__Constraint c) : this(colaPINVOKE.new_UnsatisfiableConstraintInfo(SWIGTYPE_p_vpsc__Constraint.getCPtr(c)), true) {
  }

  public uint vlid {
    set {
      colaPINVOKE.UnsatisfiableConstraintInfo_vlid_set(swigCPtr, value);
    } 
    get {
      uint ret = colaPINVOKE.UnsatisfiableConstraintInfo_vlid_get(swigCPtr);
      return ret;
    } 
  }

  public uint vrid {
    set {
      colaPINVOKE.UnsatisfiableConstraintInfo_vrid_set(swigCPtr, value);
    } 
    get {
      uint ret = colaPINVOKE.UnsatisfiableConstraintInfo_vrid_get(swigCPtr);
      return ret;
    } 
  }

  public double gap {
    set {
      colaPINVOKE.UnsatisfiableConstraintInfo_gap_set(swigCPtr, value);
    } 
    get {
      double ret = colaPINVOKE.UnsatisfiableConstraintInfo_gap_get(swigCPtr);
      return ret;
    } 
  }

}

}