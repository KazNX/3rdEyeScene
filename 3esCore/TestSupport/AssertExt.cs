using System;
using Xunit;

#pragma warning disable xUnit1013

namespace Tes.TestSupport
{
  /// <summary>
  /// Extensions for Xunit.Assert.
  /// </summary>
  public static class AssertExt
  {
    /// <summary>
    /// Asserts floating point, approximate quality.
    /// </summary>
    /// <param name="actual">The value to test</param>
    /// <param name="expected">The expected value</param>
    /// <param name="epsilon">The tolerance value; <paramref name="actual"/> may differ from
    /// <paramref name="expected"/> by up to this much.</param>
    /// <remarks>
    /// This is essentially an approximate equality assertion. This should be used for all floating point equality
    /// assertions to cater for floating point error.
    /// </remarks>
    public static void Near(float expected, float actual, float epsilon)
    {
      Near((double)expected, (double)actual, (double)epsilon);
    }

    /// <summary>
    /// Asserts floating point, approximate quality.
    /// </summary>
    /// <param name="actual">The value to test</param>
    /// <param name="expected">The expected value</param>
    /// <param name="epsilon">The tolerance value; <paramref name="actual"/> may differ from
    /// <paramref name="expected"/> by up to this much.</param>
    /// <remarks>
    /// This is essentially an approximate equality assertion. This should be used for all floating point equality
    /// assertions to cater for floating point error.
    /// </remarks>
    public static void Near(double expected, double actual, double epsilon)
    {
      Assert.True(Math.Abs(actual - expected) <= epsilon);
    }

    /// <summary>
    /// Dummy test to avoid issues in loading an Xunit dependent assembly with no tests.
    /// </summary>
    [Fact]
    public static void Dummy()
    {
      Assert.True(true);
    }
  }
}

#pragma warning restore xUnit1013
