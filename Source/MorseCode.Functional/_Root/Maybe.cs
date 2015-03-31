using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode.Functional
{
    public class Maybe<T>
    {
        #region Static Fields

        public static readonly Maybe<T> Nothing = new Maybe<T>();

        #endregion

        #region Fields

        private readonly bool hasValue;

        private readonly T value;

        #endregion

        #region Constructors and Destructors

        public Maybe(T value)
        {
            this.hasValue = true;
            this.value = value;
        }

        private Maybe()
        {
        }

        #endregion

        #region Public Methods and Operators

        public TReturn Switch<TReturn>(Func<T, TReturn> hasValueFunc, Func<TReturn> nothingFunc)
        {
            return this.hasValue ? hasValueFunc(this.value) : nothingFunc();
        }

        public override string ToString()
        {
            return this.Switch(v => "Just: " + v.SafeToString(), () => "Nothing");
        }

        #endregion
    }

    public static class MaybeMonad
    {
        #region Public Methods and Operators

        public static NotNull<Maybe<TResult>> Bind<T, TResult>(this NotNull<Maybe<T>> value, Func<T, NotNull<Maybe<TResult>>> transformation)
        {
            return value.Value.Switch(transformation, () => Maybe<TResult>.Nothing.ToNotNull());
        }

        //public static Maybe<TResult> SelectMany<T1, T2,TResult>(this Maybe<T1> value, Func<T1, Maybe<T2>> transformation,Func<T1,T2,TResult> collation)
        //{
        //    return value.Switch(transformation, () => Maybe<T2>.Nothing);
        //}
        public static NotNull<Maybe<C>> SelectMany<A, B, C>(this NotNull<Maybe<A>> a, Func<A, NotNull<Maybe<B>>> map, Func<A, B, C> select)
        {
            return a.Bind(aValue => map(aValue).Bind(bValue => new Maybe<C>(select(aValue, bValue)).ToNotNull()));
        }

        #endregion
    }

    public class hey
    {
        #region Fields

        private readonly NotNull2<string> s = new NotNull2<string>("s");

        #endregion

        #region Public Methods and Operators

        public void yo()
        {
            if (this.s.Value != null)
            {
            }
        }

        #endregion
    }

    public static class test
    {
        #region Static Fields

        private static NotNull<Maybe<int>> at;

        #endregion

        #region Public Methods and Operators

        public static void yo()
        {
            Maybe<int> v = at.Value;

            NotNull<Maybe<int>> a = new Maybe<int>(5).ToNotNull();
            NotNull<Maybe<int>> b = new Maybe<int>(7).ToNotNull();
            NotNull<Maybe<int>> c = new Maybe<int>(3).ToNotNull();

            NotNull<Maybe<int>> result = from a1 in a from b1 in b from c1 in c select a1 + b1 + c1;

            NotNull<Maybe<int>> a2 = Maybe<int>.Nothing.ToNotNull();
            NotNull<Maybe<int>> b2 = new Maybe<int>(7).ToNotNull();
            NotNull<Maybe<int>> c2 = new Maybe<int>(3).ToNotNull();
            NotNull<Maybe<int>> result2 = from a1 in a2 from b1 in b2 from c1 in c2 select a1 + b1 + c1;

            Maybe<int> r = result;
            Maybe<int> r2 = result2;

            var yo = LambdaUtility.TypeLambda((int a22, string b22, double c22) => new { yo = 5 });
        }

        #endregion
    }
}
