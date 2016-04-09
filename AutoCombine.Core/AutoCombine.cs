﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoCombine.Core
{
    public class AutoCombine
    {
        private IDictionary<Type, IEnumerable<object>> Values;
        public AutoCombine()
        {
            Values = new Dictionary<Type, IEnumerable<object>>()
            {
                {typeof(bool), new object[] {false,true } },
                {typeof(bool?), new object[] {false,true,null } },
                {typeof(byte), new object[] {byte.MinValue,byte.MaxValue } },
                {typeof(byte?), new object[] {byte.MinValue,byte.MaxValue,null } },
                {typeof(char), new object[] {char.MinValue,char.MaxValue} },
                {typeof(char), new object[] {char.MinValue,char.MaxValue, null} },
                {typeof(decimal), new object[] {decimal.MinValue,decimal.MinusOne,(decimal)0,decimal.One,decimal.MaxValue} },
                {typeof(decimal?), new object[] {decimal.MinValue,decimal.MinusOne,(decimal)0,decimal.One,decimal.MaxValue,null} },
                {typeof(double), new object[] {double.NegativeInfinity,double.MinValue,(double)0,double.MaxValue,double.PositiveInfinity,double.NaN } },
                {typeof(double?), new object[] {double.NegativeInfinity,double.MinValue,(double)0,double.MaxValue,double.PositiveInfinity, double.NaN, null } },
                {typeof(float), new object[] {float.NegativeInfinity,float.MinValue,(float)0,float.MaxValue,float.PositiveInfinity,float.NaN } },
                {typeof(float?), new object[] {float.NegativeInfinity,float.MinValue,(float)0,float.MaxValue,float.PositiveInfinity,float.NaN,null } },
                {typeof(int), new object[] {int.MinValue,-1,0,1,int.MaxValue } },
                {typeof(int?), new object[] {int.MinValue,-1,0,1,int.MaxValue,null } },
                {typeof(long), new object[] {long.MinValue,(long)0,long.MaxValue } },
                {typeof(long?), new object[] {long.MinValue,(long)0,long.MaxValue,null } },
                {typeof(sbyte), new object[] {sbyte.MinValue,(sbyte)0,sbyte.MaxValue } },
                {typeof(sbyte?), new object[] {sbyte.MinValue,(sbyte)0,sbyte.MaxValue,null } },
                {typeof(short), new object[] {short.MinValue,(short)0,short.MaxValue } },
                {typeof(short?), new object[] {short.MinValue,(short)0,short.MaxValue,null } },
                {typeof(uint), new object[] {uint.MinValue,uint.MaxValue } },
                {typeof(uint?), new object[] {uint.MinValue,uint.MaxValue,null } },
                {typeof(ulong), new object[] {ulong.MinValue,ulong.MaxValue } },
                {typeof(ulong?), new object[] {ulong.MinValue,ulong.MaxValue, null } },
                {typeof(ushort), new object[] {ushort.MinValue,ushort.MaxValue} },
                {typeof(ushort), new object[] {ushort.MinValue,ushort.MaxValue,null} },
                {typeof(string), new string[] {"","aString" } },
            };
        }
    }
}