// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using System.Diagnostics.CodeAnalysis;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// This class is registered as transient.
    /// </summary>
    public interface IFakeClassnameTags123Api : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        FakeClassnameTags123ApiEvents Events { get; }

        /// <summary>
        /// To test class name in snake case
        /// </summary>
        /// <remarks>
        /// To test class name in snake case
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ITestClassnameApiResponse"/>&gt;</returns>
        Task<ITestClassnameApiResponse> TestClassnameAsync(ModelClient modelClient, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// To test class name in snake case
        /// </summary>
        /// <remarks>
        /// To test class name in snake case
        /// </remarks>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ITestClassnameApiResponse"/>&gt;</returns>
        Task<ITestClassnameApiResponse> TestClassnameOrDefaultAsync(ModelClient modelClient, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="ITestClassnameApiResponse"/>
    /// </summary>
    public interface ITestClassnameApiResponse : Org.OpenAPITools.Client.IApiResponse, IOk<Org.OpenAPITools.Model.ModelClient>
    {
        /// <summary>
        /// Returns true if the response is 200 Ok
        /// </summary>
        /// <returns></returns>
        bool IsOk { get; }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FakeClassnameTags123ApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs> OnTestClassname;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs> OnErrorTestClassname;

        internal void ExecuteOnTestClassname(FakeClassnameTags123Api.TestClassnameApiResponse apiResponse)
        {
            OnTestClassname?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorTestClassname(Exception exception)
        {
            OnErrorTestClassname?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class FakeClassnameTags123Api : IFakeClassnameTags123Api
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<FakeClassnameTags123Api> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public FakeClassnameTags123ApiEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="BearerToken"/>
        /// </summary>
        public TokenProvider<BearerToken> BearerTokenProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="BasicTokenProvider"/>
        /// </summary>
        public TokenProvider<BasicToken> BasicTokenProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="HttpSignatureTokenProvider"/>
        /// </summary>
        public TokenProvider<HttpSignatureToken> HttpSignatureTokenProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="OauthTokenProvider"/>
        /// </summary>
        public TokenProvider<OAuthToken> OauthTokenProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FakeClassnameTags123Api"/> class.
        /// </summary>
        /// <returns></returns>
        public FakeClassnameTags123Api(ILogger<FakeClassnameTags123Api> logger, ILoggerFactory loggerFactory, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, FakeClassnameTags123ApiEvents fakeClassnameTags123ApiEvents,
            TokenProvider<ApiKeyToken> apiKeyProvider,
            TokenProvider<BearerToken> bearerTokenProvider,
            TokenProvider<BasicToken> basicTokenProvider,
            TokenProvider<HttpSignatureToken> httpSignatureTokenProvider,
            TokenProvider<OAuthToken> oauthTokenProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<FakeClassnameTags123Api>();
            HttpClient = httpClient;
            Events = fakeClassnameTags123ApiEvents;
            ApiKeyProvider = apiKeyProvider;
            BearerTokenProvider = bearerTokenProvider;
            BasicTokenProvider = basicTokenProvider;
            HttpSignatureTokenProvider = httpSignatureTokenProvider;
            OauthTokenProvider = oauthTokenProvider;
        }

        partial void FormatTestClassname(ModelClient modelClient);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="modelClient"></param>
        /// <returns></returns>
        private void ValidateTestClassname(ModelClient modelClient)
        {
            if (modelClient == null)
                throw new ArgumentNullException(nameof(modelClient));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="modelClient"></param>
        private void AfterTestClassnameDefaultImplementation(ITestClassnameApiResponse apiResponseLocalVar, ModelClient modelClient)
        {
            bool suppressDefaultLog = false;
            AfterTestClassname(ref suppressDefaultLog, apiResponseLocalVar, modelClient);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="modelClient"></param>
        partial void AfterTestClassname(ref bool suppressDefaultLog, ITestClassnameApiResponse apiResponseLocalVar, ModelClient modelClient);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="modelClient"></param>
        private void OnErrorTestClassnameDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, ModelClient modelClient)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorTestClassname(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar, modelClient);
            if (!suppressDefaultLogLocalVar)
                Logger.LogError(exceptionLocalVar, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="suppressDefaultLogLocalVar"></param>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="modelClient"></param>
        partial void OnErrorTestClassname(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, ModelClient modelClient);

        /// <summary>
        /// To test class name in snake case To test class name in snake case
        /// </summary>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ITestClassnameApiResponse"/>&gt;</returns>
        public async Task<ITestClassnameApiResponse> TestClassnameOrDefaultAsync(ModelClient modelClient, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await TestClassnameAsync(modelClient, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// To test class name in snake case To test class name in snake case
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ITestClassnameApiResponse"/>&gt;</returns>
        public async Task<ITestClassnameApiResponse> TestClassnameAsync(ModelClient modelClient, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateTestClassname(modelClient);

                FormatTestClassname(modelClient);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/fake_classname_test";

                    System.Collections.Specialized.NameValueCollection parseQueryStringLocalVar = System.Web.HttpUtility.ParseQueryString(string.Empty);

                    httpRequestMessageLocalVar.Content = (modelClient as object) is System.IO.Stream stream
                        ? httpRequestMessageLocalVar.Content = new StreamContent(stream)
                        : httpRequestMessageLocalVar.Content = new StringContent(JsonSerializer.Serialize(modelClient, _jsonSerializerOptions));

                    List<TokenBase> tokenBaseLocalVars = new List<TokenBase>();
                    ApiKeyToken apiKeyTokenLocalVar1 = (ApiKeyToken) await ApiKeyProvider.GetAsync("api_key_query", cancellationToken).ConfigureAwait(false);
                    tokenBaseLocalVars.Add(apiKeyTokenLocalVar1);

                    apiKeyTokenLocalVar1.UseInQuery(httpRequestMessageLocalVar, uriBuilderLocalVar, parseQueryStringLocalVar);

                    uriBuilderLocalVar.Query = parseQueryStringLocalVar.ToString();
                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] contentTypes = new string[] {
                        "application/json"
                    };

                    string contentTypeLocalVar = ClientUtils.SelectHeaderContentType(contentTypes);

                    if (contentTypeLocalVar != null && httpRequestMessageLocalVar.Content != null)
                        httpRequestMessageLocalVar.Content.Headers.ContentType = new MediaTypeHeaderValue(contentTypeLocalVar);

                    string[] acceptLocalVars = new string[] {
                        "application/json"
                    };

                    string acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));
                    httpRequestMessageLocalVar.Method = new HttpMethod("PATCH");

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync().ConfigureAwait(false);

                        ILogger<TestClassnameApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<TestClassnameApiResponse>();

                        TestClassnameApiResponse apiResponseLocalVar = new TestClassnameApiResponse(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/fake_classname_test", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterTestClassnameDefaultImplementation(apiResponseLocalVar, modelClient);

                        Events.ExecuteOnTestClassname(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorTestClassnameDefaultImplementation(e, "/fake_classname_test", uriBuilderLocalVar.Path, modelClient);
                Events.ExecuteOnErrorTestClassname(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="TestClassnameApiResponse"/>
        /// </summary>
        public partial class TestClassnameApiResponse : Org.OpenAPITools.Client.ApiResponse, ITestClassnameApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<TestClassnameApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="TestClassnameApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public TestClassnameApiResponse(ILogger<TestClassnameApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
            {
                Logger = logger;
                OnCreated(httpRequestMessage, httpResponseMessage);
            }

            partial void OnCreated(global::System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);

            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public bool IsOk => 200 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public Org.OpenAPITools.Model.ModelClient Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<Org.OpenAPITools.Model.ModelClient>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk(out Org.OpenAPITools.Model.ModelClient result)
            {
                result = null;

                try
                {
                    result = Ok();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)200);
                }

                return result != null;
            }

            private void OnDeserializationErrorDefaultImplementation(Exception exception, HttpStatusCode httpStatusCode)
            {
                bool suppressDefaultLog = false;
                OnDeserializationError(ref suppressDefaultLog, exception, httpStatusCode);
                if (!suppressDefaultLog)
                    Logger.LogError(exception, "An error occurred while deserializing the {code} response.", httpStatusCode);
            }

            partial void OnDeserializationError(ref bool suppressDefaultLog, Exception exception, HttpStatusCode httpStatusCode);
        }
    }
}
