using System.Collections.Generic;
using Nano.Models.Interfaces;
using Nano.Web.Api.Requests.Interfaces;

namespace Nano.Web.Api.Requests
{
    /// <summary>
    /// Update Request.
    /// </summary>
    public class UpdateRequest<TEntity> : BaseRequest, IRequestJson
        where TEntity : IEntityUpdatable
    {
        /// <summary>
        /// Entity.
        /// </summary>
        public virtual TEntity Entity { get; set; }

        /// <inheritdoc cref="IRequest.GetQueryStringParameters()"/>
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            return new List<KeyValuePair<string, string>>();
        }
    }
}