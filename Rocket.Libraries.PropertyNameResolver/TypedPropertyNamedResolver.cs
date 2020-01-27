using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Rocket.Libraries.PropertyNameResolver
{
    public sealed class TypedPropertyNamedResolver<TObject> : IDisposable
    {
        public void Dispose()
        {
        }

        public string Resolve<TPropertyType>(Expression<Func<TObject, TPropertyType>> resolverExpression)
        {
            using (var propertyNameResolver = new PropertyNameResolver())
            {
                return propertyNameResolver.Resolve(resolverExpression);
            }
        }
    }
}