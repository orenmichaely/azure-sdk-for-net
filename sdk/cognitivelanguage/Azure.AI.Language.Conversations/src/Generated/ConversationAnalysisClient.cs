// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.Language.Conversations
{
    /// <summary> The ConversationAnalysis service client. </summary>
    public partial class ConversationAnalysisClient
    {
        private const string AuthorizationHeader = "Ocp-Apim-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Analyzes the input conversation utterance. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   kind: &quot;Conversation&quot; (required)
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   kind: &quot;ConversationResult&quot;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: &quot;InvalidRequest&quot; | &quot;InvalidArgument&quot; | &quot;Unauthorized&quot; | &quot;Forbidden&quot; | &quot;NotFound&quot; | &quot;ProjectNotFound&quot; | &quot;OperationNotFound&quot; | &quot;AzureCognitiveSearchNotFound&quot; | &quot;AzureCognitiveSearchIndexNotFound&quot; | &quot;TooManyRequests&quot; | &quot;AzureCognitiveSearchThrottling&quot; | &quot;AzureCognitiveSearchIndexLimitReached&quot; | &quot;InternalServerError&quot; | &quot;ServiceUnavailable&quot;,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: &quot;InvalidRequest&quot; | &quot;InvalidParameterValue&quot; | &quot;KnowledgeBaseNotFound&quot; | &quot;AzureCognitiveSearchNotFound&quot; | &quot;AzureCognitiveSearchThrottling&quot; | &quot;ExtractionFailure&quot; | &quot;InvalidRequestBodyFormat&quot; | &quot;EmptyRequest&quot; | &quot;MissingInputDocuments&quot; | &quot;InvalidDocument&quot; | &quot;ModelVersionIncorrect&quot; | &quot;InvalidDocumentBatch&quot; | &quot;UnsupportedLanguageCode&quot; | &quot;InvalidCountryHint&quot;,
        ///       message: string,
        ///       details: Dictionary&lt;string, string&gt;,
        ///       target: string,
        ///       innererror: InnerErrorModel
        ///     }
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> AnalyzeConversationAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ConversationAnalysisClient.AnalyzeConversation");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAnalyzeConversationRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Analyzes the input conversation utterance. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   kind: &quot;Conversation&quot; (required)
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   kind: &quot;ConversationResult&quot;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: &quot;InvalidRequest&quot; | &quot;InvalidArgument&quot; | &quot;Unauthorized&quot; | &quot;Forbidden&quot; | &quot;NotFound&quot; | &quot;ProjectNotFound&quot; | &quot;OperationNotFound&quot; | &quot;AzureCognitiveSearchNotFound&quot; | &quot;AzureCognitiveSearchIndexNotFound&quot; | &quot;TooManyRequests&quot; | &quot;AzureCognitiveSearchThrottling&quot; | &quot;AzureCognitiveSearchIndexLimitReached&quot; | &quot;InternalServerError&quot; | &quot;ServiceUnavailable&quot;,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: &quot;InvalidRequest&quot; | &quot;InvalidParameterValue&quot; | &quot;KnowledgeBaseNotFound&quot; | &quot;AzureCognitiveSearchNotFound&quot; | &quot;AzureCognitiveSearchThrottling&quot; | &quot;ExtractionFailure&quot; | &quot;InvalidRequestBodyFormat&quot; | &quot;EmptyRequest&quot; | &quot;MissingInputDocuments&quot; | &quot;InvalidDocument&quot; | &quot;ModelVersionIncorrect&quot; | &quot;InvalidDocumentBatch&quot; | &quot;UnsupportedLanguageCode&quot; | &quot;InvalidCountryHint&quot;,
        ///       message: string,
        ///       details: Dictionary&lt;string, string&gt;,
        ///       target: string,
        ///       innererror: InnerErrorModel
        ///     }
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response AnalyzeConversation(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ConversationAnalysisClient.AnalyzeConversation");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAnalyzeConversationRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the status of an analysis job. A job may consist of one or more tasks. Once all tasks are succeeded, the job will transition to the succeeded state and results will be available for each task. </summary>
        /// <param name="jobId"> Job ID. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   displayName: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   expirationDateTime: string (ISO 8601 Format),
        ///   jobId: JobStateJobId,
        ///   lastUpdateDateTime: string (ISO 8601 Format),
        ///   status: JobState,
        ///   errors: [
        ///     {
        ///       code: &quot;InvalidRequest&quot; | &quot;InvalidArgument&quot; | &quot;Unauthorized&quot; | &quot;Forbidden&quot; | &quot;NotFound&quot; | &quot;ProjectNotFound&quot; | &quot;OperationNotFound&quot; | &quot;AzureCognitiveSearchNotFound&quot; | &quot;AzureCognitiveSearchIndexNotFound&quot; | &quot;TooManyRequests&quot; | &quot;AzureCognitiveSearchThrottling&quot; | &quot;AzureCognitiveSearchIndexLimitReached&quot; | &quot;InternalServerError&quot; | &quot;ServiceUnavailable&quot;,
        ///       message: string,
        ///       target: string,
        ///       details: [Error],
        ///       innererror: {
        ///         code: &quot;InvalidRequest&quot; | &quot;InvalidParameterValue&quot; | &quot;KnowledgeBaseNotFound&quot; | &quot;AzureCognitiveSearchNotFound&quot; | &quot;AzureCognitiveSearchThrottling&quot; | &quot;ExtractionFailure&quot; | &quot;InvalidRequestBodyFormat&quot; | &quot;EmptyRequest&quot; | &quot;MissingInputDocuments&quot; | &quot;InvalidDocument&quot; | &quot;ModelVersionIncorrect&quot; | &quot;InvalidDocumentBatch&quot; | &quot;UnsupportedLanguageCode&quot; | &quot;InvalidCountryHint&quot;,
        ///         message: string,
        ///         details: Dictionary&lt;string, string&gt;,
        ///         target: string,
        ///         innererror: InnerErrorModel
        ///       }
        ///     }
        ///   ],
        ///   nextLink: string,
        ///   tasks: {
        ///     completed: number,
        ///     failed: number,
        ///     inProgress: number,
        ///     total: number,
        ///     items: [
        ///       {
        ///         lastUpdateDateTime: string (ISO 8601 Format),
        ///         status: TaskState,
        ///         taskName: string,
        ///         kind: &quot;conversationalSummarizationResults&quot; | &quot;conversationalPIIResults&quot;
        ///       }
        ///     ]
        ///   },
        ///   statistics: {
        ///     transactionsCount: number,
        ///     conversationsCount: number,
        ///     validConversationsCount: number,
        ///     erroneousConversationsCount: number
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: &quot;InvalidRequest&quot; | &quot;InvalidArgument&quot; | &quot;Unauthorized&quot; | &quot;Forbidden&quot; | &quot;NotFound&quot; | &quot;ProjectNotFound&quot; | &quot;OperationNotFound&quot; | &quot;AzureCognitiveSearchNotFound&quot; | &quot;AzureCognitiveSearchIndexNotFound&quot; | &quot;TooManyRequests&quot; | &quot;AzureCognitiveSearchThrottling&quot; | &quot;AzureCognitiveSearchIndexLimitReached&quot; | &quot;InternalServerError&quot; | &quot;ServiceUnavailable&quot;,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: &quot;InvalidRequest&quot; | &quot;InvalidParameterValue&quot; | &quot;KnowledgeBaseNotFound&quot; | &quot;AzureCognitiveSearchNotFound&quot; | &quot;AzureCognitiveSearchThrottling&quot; | &quot;ExtractionFailure&quot; | &quot;InvalidRequestBodyFormat&quot; | &quot;EmptyRequest&quot; | &quot;MissingInputDocuments&quot; | &quot;InvalidDocument&quot; | &quot;ModelVersionIncorrect&quot; | &quot;InvalidDocumentBatch&quot; | &quot;UnsupportedLanguageCode&quot; | &quot;InvalidCountryHint&quot;,
        ///       message: string,
        ///       details: Dictionary&lt;string, string&gt;,
        ///       target: string,
        ///       innererror: InnerErrorModel
        ///     }
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> JobStatusAsync(Guid jobId, bool? showStats = null, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ConversationAnalysisClient.JobStatus");
            scope.Start();
            try
            {
                using HttpMessage message = CreateJobStatusRequest(jobId, showStats, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the status of an analysis job. A job may consist of one or more tasks. Once all tasks are succeeded, the job will transition to the succeeded state and results will be available for each task. </summary>
        /// <param name="jobId"> Job ID. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   displayName: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   expirationDateTime: string (ISO 8601 Format),
        ///   jobId: JobStateJobId,
        ///   lastUpdateDateTime: string (ISO 8601 Format),
        ///   status: JobState,
        ///   errors: [
        ///     {
        ///       code: &quot;InvalidRequest&quot; | &quot;InvalidArgument&quot; | &quot;Unauthorized&quot; | &quot;Forbidden&quot; | &quot;NotFound&quot; | &quot;ProjectNotFound&quot; | &quot;OperationNotFound&quot; | &quot;AzureCognitiveSearchNotFound&quot; | &quot;AzureCognitiveSearchIndexNotFound&quot; | &quot;TooManyRequests&quot; | &quot;AzureCognitiveSearchThrottling&quot; | &quot;AzureCognitiveSearchIndexLimitReached&quot; | &quot;InternalServerError&quot; | &quot;ServiceUnavailable&quot;,
        ///       message: string,
        ///       target: string,
        ///       details: [Error],
        ///       innererror: {
        ///         code: &quot;InvalidRequest&quot; | &quot;InvalidParameterValue&quot; | &quot;KnowledgeBaseNotFound&quot; | &quot;AzureCognitiveSearchNotFound&quot; | &quot;AzureCognitiveSearchThrottling&quot; | &quot;ExtractionFailure&quot; | &quot;InvalidRequestBodyFormat&quot; | &quot;EmptyRequest&quot; | &quot;MissingInputDocuments&quot; | &quot;InvalidDocument&quot; | &quot;ModelVersionIncorrect&quot; | &quot;InvalidDocumentBatch&quot; | &quot;UnsupportedLanguageCode&quot; | &quot;InvalidCountryHint&quot;,
        ///         message: string,
        ///         details: Dictionary&lt;string, string&gt;,
        ///         target: string,
        ///         innererror: InnerErrorModel
        ///       }
        ///     }
        ///   ],
        ///   nextLink: string,
        ///   tasks: {
        ///     completed: number,
        ///     failed: number,
        ///     inProgress: number,
        ///     total: number,
        ///     items: [
        ///       {
        ///         lastUpdateDateTime: string (ISO 8601 Format),
        ///         status: TaskState,
        ///         taskName: string,
        ///         kind: &quot;conversationalSummarizationResults&quot; | &quot;conversationalPIIResults&quot;
        ///       }
        ///     ]
        ///   },
        ///   statistics: {
        ///     transactionsCount: number,
        ///     conversationsCount: number,
        ///     validConversationsCount: number,
        ///     erroneousConversationsCount: number
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: &quot;InvalidRequest&quot; | &quot;InvalidArgument&quot; | &quot;Unauthorized&quot; | &quot;Forbidden&quot; | &quot;NotFound&quot; | &quot;ProjectNotFound&quot; | &quot;OperationNotFound&quot; | &quot;AzureCognitiveSearchNotFound&quot; | &quot;AzureCognitiveSearchIndexNotFound&quot; | &quot;TooManyRequests&quot; | &quot;AzureCognitiveSearchThrottling&quot; | &quot;AzureCognitiveSearchIndexLimitReached&quot; | &quot;InternalServerError&quot; | &quot;ServiceUnavailable&quot;,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: &quot;InvalidRequest&quot; | &quot;InvalidParameterValue&quot; | &quot;KnowledgeBaseNotFound&quot; | &quot;AzureCognitiveSearchNotFound&quot; | &quot;AzureCognitiveSearchThrottling&quot; | &quot;ExtractionFailure&quot; | &quot;InvalidRequestBodyFormat&quot; | &quot;EmptyRequest&quot; | &quot;MissingInputDocuments&quot; | &quot;InvalidDocument&quot; | &quot;ModelVersionIncorrect&quot; | &quot;InvalidDocumentBatch&quot; | &quot;UnsupportedLanguageCode&quot; | &quot;InvalidCountryHint&quot;,
        ///       message: string,
        ///       details: Dictionary&lt;string, string&gt;,
        ///       target: string,
        ///       innererror: InnerErrorModel
        ///     }
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response JobStatus(Guid jobId, bool? showStats = null, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ConversationAnalysisClient.JobStatus");
            scope.Start();
            try
            {
                using HttpMessage message = CreateJobStatusRequest(jobId, showStats, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Submit a collection of conversations for analysis. Specify one or more unique tasks to be executed. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   displayName: string,
        ///   analysisInput: {
        ///     conversations: [
        ///       {
        ///         id: string (required),
        ///         language: string (required),
        ///         modality: &quot;transcript&quot; | &quot;text&quot; (required),
        ///         domain: &quot;finance&quot; | &quot;healthcare&quot; | &quot;generic&quot;
        ///       }
        ///     ] (required)
        ///   } (required),
        ///   tasks: [
        ///     {
        ///       taskName: string,
        ///       kind: &quot;ConversationalPIITask&quot; | &quot;ConversationalSummarizationTask&quot; (required)
        ///     }
        ///   ] (required)
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: &quot;InvalidRequest&quot; | &quot;InvalidArgument&quot; | &quot;Unauthorized&quot; | &quot;Forbidden&quot; | &quot;NotFound&quot; | &quot;ProjectNotFound&quot; | &quot;OperationNotFound&quot; | &quot;AzureCognitiveSearchNotFound&quot; | &quot;AzureCognitiveSearchIndexNotFound&quot; | &quot;TooManyRequests&quot; | &quot;AzureCognitiveSearchThrottling&quot; | &quot;AzureCognitiveSearchIndexLimitReached&quot; | &quot;InternalServerError&quot; | &quot;ServiceUnavailable&quot;,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: &quot;InvalidRequest&quot; | &quot;InvalidParameterValue&quot; | &quot;KnowledgeBaseNotFound&quot; | &quot;AzureCognitiveSearchNotFound&quot; | &quot;AzureCognitiveSearchThrottling&quot; | &quot;ExtractionFailure&quot; | &quot;InvalidRequestBodyFormat&quot; | &quot;EmptyRequest&quot; | &quot;MissingInputDocuments&quot; | &quot;InvalidDocument&quot; | &quot;ModelVersionIncorrect&quot; | &quot;InvalidDocumentBatch&quot; | &quot;UnsupportedLanguageCode&quot; | &quot;InvalidCountryHint&quot;,
        ///       message: string,
        ///       details: Dictionary&lt;string, string&gt;,
        ///       target: string,
        ///       innererror: InnerErrorModel
        ///     }
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Operation<BinaryData>> SubmitJobAsync(WaitUntil waitUntil, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ConversationAnalysisClient.SubmitJob");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSubmitJobRequest(content, context);
                return await LowLevelOperationHelpers.ProcessMessageAsync(_pipeline, message, ClientDiagnostics, "ConversationAnalysisClient.SubmitJob", OperationFinalStateVia.Location, context, waitUntil).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Submit a collection of conversations for analysis. Specify one or more unique tasks to be executed. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   displayName: string,
        ///   analysisInput: {
        ///     conversations: [
        ///       {
        ///         id: string (required),
        ///         language: string (required),
        ///         modality: &quot;transcript&quot; | &quot;text&quot; (required),
        ///         domain: &quot;finance&quot; | &quot;healthcare&quot; | &quot;generic&quot;
        ///       }
        ///     ] (required)
        ///   } (required),
        ///   tasks: [
        ///     {
        ///       taskName: string,
        ///       kind: &quot;ConversationalPIITask&quot; | &quot;ConversationalSummarizationTask&quot; (required)
        ///     }
        ///   ] (required)
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: &quot;InvalidRequest&quot; | &quot;InvalidArgument&quot; | &quot;Unauthorized&quot; | &quot;Forbidden&quot; | &quot;NotFound&quot; | &quot;ProjectNotFound&quot; | &quot;OperationNotFound&quot; | &quot;AzureCognitiveSearchNotFound&quot; | &quot;AzureCognitiveSearchIndexNotFound&quot; | &quot;TooManyRequests&quot; | &quot;AzureCognitiveSearchThrottling&quot; | &quot;AzureCognitiveSearchIndexLimitReached&quot; | &quot;InternalServerError&quot; | &quot;ServiceUnavailable&quot;,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: &quot;InvalidRequest&quot; | &quot;InvalidParameterValue&quot; | &quot;KnowledgeBaseNotFound&quot; | &quot;AzureCognitiveSearchNotFound&quot; | &quot;AzureCognitiveSearchThrottling&quot; | &quot;ExtractionFailure&quot; | &quot;InvalidRequestBodyFormat&quot; | &quot;EmptyRequest&quot; | &quot;MissingInputDocuments&quot; | &quot;InvalidDocument&quot; | &quot;ModelVersionIncorrect&quot; | &quot;InvalidDocumentBatch&quot; | &quot;UnsupportedLanguageCode&quot; | &quot;InvalidCountryHint&quot;,
        ///       message: string,
        ///       details: Dictionary&lt;string, string&gt;,
        ///       target: string,
        ///       innererror: InnerErrorModel
        ///     }
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Operation<BinaryData> SubmitJob(WaitUntil waitUntil, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ConversationAnalysisClient.SubmitJob");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSubmitJobRequest(content, context);
                return LowLevelOperationHelpers.ProcessMessage(_pipeline, message, ClientDiagnostics, "ConversationAnalysisClient.SubmitJob", OperationFinalStateVia.Location, context, waitUntil);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateAnalyzeConversationRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/language", false);
            uri.AppendPath("/:analyze-conversations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateSubmitJobRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier202);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/language", false);
            uri.AppendPath("/analyze-conversations/jobs", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateJobStatusRequest(Guid jobId, bool? showStats, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/language", false);
            uri.AppendPath("/analyze-conversations/jobs/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (showStats != null)
            {
                uri.AppendQuery("showStats", showStats.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
        private static ResponseClassifier _responseClassifier202;
        private static ResponseClassifier ResponseClassifier202 => _responseClassifier202 ??= new StatusCodeClassifier(stackalloc ushort[] { 202 });
    }
}
