﻿using System.Diagnostics;
using NUnit.Framework;
using System;

namespace Shouldly
{
    [DebuggerStepThrough]
    [ShouldlyMethods]
    public static class ShouldBeTestExtensions
    {
        public static void ShouldBe<T>(this T actual, T expected)
        {
            actual.AssertAwesomely(Is.EqualTo(expected), actual, expected);
        }


        public static void ShouldBeTypeOf(this object actual, Type expected) {
            actual.AssertAwesomely(Is.InstanceOf(expected), actual, expected);
        }
        public static void ShouldNotBeTypeOf(this object actual, Type expected) {
            actual.AssertAwesomely(!Is.InstanceOf(expected), actual, expected);
        }

        public static void ShouldNotBe<T>(this T actual, T expected)
        {
            actual.AssertAwesomely(Is.Not.EqualTo(expected), actual, expected);
        }

        public static void ShouldBe(this float actual, float expected, double tolerance)
        {
            actual.AssertAwesomely(Is.EqualTo(expected).Within(tolerance), actual, expected);
        }

        public static void ShouldBe(this double actual, double expected, double tolerance)
        {
            actual.AssertAwesomely(Is.EqualTo(expected).Within(tolerance), actual, expected);
        }

        public static void ShouldBeGreaterThan(this object actual, object expected)
        {
            actual.AssertAwesomely(Is.GreaterThan(expected), actual, expected);
        }

        public static void ShouldBeLessThan(this object actual, object expected)
        {
            actual.AssertAwesomely(Is.LessThan(expected), actual, expected);
        }
    }
}
