using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientsLib
{
    public class UriFactory : IUriFactory
    {
        private readonly string _basePath;
        private readonly string[] _segments;
        private readonly KeyValuePair<string, string>[] _parameters;

        public UriFactory(string basePath, string[] segments, params KeyValuePair<string, string>[] parameters)
        {
            if (string.IsNullOrEmpty(basePath))
            {
                throw new ArgumentException("Base path cannot be null, empty, or white space.", nameof(basePath));
            }

            _basePath = basePath.TrimEnd('/');

            _segments = segments ?? throw new ArgumentNullException(nameof(segments));
            _segments = segments.Select(s => s.Split('/'))
                                .SelectMany(l => l)
                                .Where(s => !String.IsNullOrWhiteSpace(s))
                                .ToArray();

            _parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
        }

        /// <summary>
        /// Use this constructor to pass in the intial value of the API key.
        /// </summary>
        /// <param name="basePath"></param>
        /// <param name="api_key">The given API key to allow access to the API.</param>
        public UriFactory(string basePath, string api_key)
            : this(basePath, Array.Empty<string>(), new KeyValuePair<string, string>(nameof(api_key), api_key))
        {
        }

        /// <summary>
        /// Adds or appends additional Queries to be added to a Uri object.
        /// </summary>
        /// <param name="parameters">A key value pair of the query's key and it's value of a Uri.</param>
        /// <returns>Returns a new instance of UriFactory with updated parameters field.</returns>
        public IUriFactory AddParameters(params KeyValuePair<string, string>[] parameters) => 
            new UriFactory(_basePath, _segments, _parameters.Concat(parameters).ToArray());

        /// <summary>
        /// Adds or appends additional Paths to be added to a Uri object.
        /// </summary>
        /// <param name="segments">A string value of the path of a Uri.</param>
        /// <returns>Returns a new instance of UriFactory with updated segments field.</returns>
        public IUriFactory AddSegments(params string[] segments) =>
            new UriFactory(_basePath, _segments.Concat(segments).ToArray(), _parameters);

        /// <summary>
        /// Builds and returns the finalized absolute Uri. Create the Uri.Path through AddSegments. Create the Uri.Query through AddParameters.
        /// </summary>
        /// <returns>Returns a finalized absolute Uri.</returns>
        public Uri Create()
        {
            var path = $"{_basePath}/{String.Join('/', _segments)}/";
            var builder = new UriBuilder(path);
            var parameters = _parameters
                .Select(kvp => $"{kvp.Key}={kvp.Value}");
            builder.Query = $"{String.Join('&', parameters)}";

            return builder.Uri;
        }
    }
}
