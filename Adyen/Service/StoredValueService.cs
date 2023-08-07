/*
* Adyen Stored Value API
*
*
* The version of the OpenAPI document: 46
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Constants;
using Adyen.Model;
using Adyen.Model.StoredValue;

namespace Adyen.Service
{
    /// <summary>
    /// DefaultService Interface
    /// </summary>
    public interface IStoredValueService
    {
        /// <summary>
        /// Changes the status of the payment method.
        /// </summary>
        /// <param name="storedValueStatusChangeRequest"><see cref="StoredValueStatusChangeRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="StoredValueStatusChangeResponse"/>.</returns>
        Model.StoredValue.StoredValueStatusChangeResponse ChangeStatus(StoredValueStatusChangeRequest storedValueStatusChangeRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Changes the status of the payment method.
        /// </summary>
        /// <param name="storedValueStatusChangeRequest"><see cref="StoredValueStatusChangeRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="StoredValueStatusChangeResponse"/>.</returns>
        Task<Model.StoredValue.StoredValueStatusChangeResponse> ChangeStatusAsync(StoredValueStatusChangeRequest storedValueStatusChangeRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Checks the balance.
        /// </summary>
        /// <param name="storedValueBalanceCheckRequest"><see cref="StoredValueBalanceCheckRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="StoredValueBalanceCheckResponse"/>.</returns>
        Model.StoredValue.StoredValueBalanceCheckResponse CheckBalance(StoredValueBalanceCheckRequest storedValueBalanceCheckRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Checks the balance.
        /// </summary>
        /// <param name="storedValueBalanceCheckRequest"><see cref="StoredValueBalanceCheckRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="StoredValueBalanceCheckResponse"/>.</returns>
        Task<Model.StoredValue.StoredValueBalanceCheckResponse> CheckBalanceAsync(StoredValueBalanceCheckRequest storedValueBalanceCheckRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Issues a new card.
        /// </summary>
        /// <param name="storedValueIssueRequest"><see cref="StoredValueIssueRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="StoredValueIssueResponse"/>.</returns>
        Model.StoredValue.StoredValueIssueResponse Issue(StoredValueIssueRequest storedValueIssueRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Issues a new card.
        /// </summary>
        /// <param name="storedValueIssueRequest"><see cref="StoredValueIssueRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="StoredValueIssueResponse"/>.</returns>
        Task<Model.StoredValue.StoredValueIssueResponse> IssueAsync(StoredValueIssueRequest storedValueIssueRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Loads the payment method.
        /// </summary>
        /// <param name="storedValueLoadRequest"><see cref="StoredValueLoadRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="StoredValueLoadResponse"/>.</returns>
        Model.StoredValue.StoredValueLoadResponse Load(StoredValueLoadRequest storedValueLoadRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Loads the payment method.
        /// </summary>
        /// <param name="storedValueLoadRequest"><see cref="StoredValueLoadRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="StoredValueLoadResponse"/>.</returns>
        Task<Model.StoredValue.StoredValueLoadResponse> LoadAsync(StoredValueLoadRequest storedValueLoadRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Merge the balance of two cards.
        /// </summary>
        /// <param name="storedValueBalanceMergeRequest"><see cref="StoredValueBalanceMergeRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="StoredValueBalanceMergeResponse"/>.</returns>
        Model.StoredValue.StoredValueBalanceMergeResponse MergeBalance(StoredValueBalanceMergeRequest storedValueBalanceMergeRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Merge the balance of two cards.
        /// </summary>
        /// <param name="storedValueBalanceMergeRequest"><see cref="StoredValueBalanceMergeRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="StoredValueBalanceMergeResponse"/>.</returns>
        Task<Model.StoredValue.StoredValueBalanceMergeResponse> MergeBalanceAsync(StoredValueBalanceMergeRequest storedValueBalanceMergeRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Voids a transaction.
        /// </summary>
        /// <param name="storedValueVoidRequest"><see cref="StoredValueVoidRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="StoredValueVoidResponse"/>.</returns>
        Model.StoredValue.StoredValueVoidResponse VoidTransaction(StoredValueVoidRequest storedValueVoidRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Voids a transaction.
        /// </summary>
        /// <param name="storedValueVoidRequest"><see cref="StoredValueVoidRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="StoredValueVoidResponse"/>.</returns>
        Task<Model.StoredValue.StoredValueVoidResponse> VoidTransactionAsync(StoredValueVoidRequest storedValueVoidRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the StoredValueService API endpoints
    /// </summary>
    public class StoredValueService : AbstractService, IStoredValueService
    {
        private readonly string _baseUrl;
        
        public StoredValueService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://pal-test.adyen.com/pal/servlet/StoredValue/v46");
        }
        
        public Model.StoredValue.StoredValueStatusChangeResponse ChangeStatus(StoredValueStatusChangeRequest storedValueStatusChangeRequest = default, RequestOptions requestOptions = default)
        {
            return ChangeStatusAsync(storedValueStatusChangeRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.StoredValue.StoredValueStatusChangeResponse> ChangeStatusAsync(StoredValueStatusChangeRequest storedValueStatusChangeRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/changeStatus";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.StoredValue.StoredValueStatusChangeResponse>(storedValueStatusChangeRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.StoredValue.StoredValueBalanceCheckResponse CheckBalance(StoredValueBalanceCheckRequest storedValueBalanceCheckRequest = default, RequestOptions requestOptions = default)
        {
            return CheckBalanceAsync(storedValueBalanceCheckRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.StoredValue.StoredValueBalanceCheckResponse> CheckBalanceAsync(StoredValueBalanceCheckRequest storedValueBalanceCheckRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/checkBalance";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.StoredValue.StoredValueBalanceCheckResponse>(storedValueBalanceCheckRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.StoredValue.StoredValueIssueResponse Issue(StoredValueIssueRequest storedValueIssueRequest = default, RequestOptions requestOptions = default)
        {
            return IssueAsync(storedValueIssueRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.StoredValue.StoredValueIssueResponse> IssueAsync(StoredValueIssueRequest storedValueIssueRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/issue";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.StoredValue.StoredValueIssueResponse>(storedValueIssueRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.StoredValue.StoredValueLoadResponse Load(StoredValueLoadRequest storedValueLoadRequest = default, RequestOptions requestOptions = default)
        {
            return LoadAsync(storedValueLoadRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.StoredValue.StoredValueLoadResponse> LoadAsync(StoredValueLoadRequest storedValueLoadRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/load";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.StoredValue.StoredValueLoadResponse>(storedValueLoadRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.StoredValue.StoredValueBalanceMergeResponse MergeBalance(StoredValueBalanceMergeRequest storedValueBalanceMergeRequest = default, RequestOptions requestOptions = default)
        {
            return MergeBalanceAsync(storedValueBalanceMergeRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.StoredValue.StoredValueBalanceMergeResponse> MergeBalanceAsync(StoredValueBalanceMergeRequest storedValueBalanceMergeRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/mergeBalance";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.StoredValue.StoredValueBalanceMergeResponse>(storedValueBalanceMergeRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.StoredValue.StoredValueVoidResponse VoidTransaction(StoredValueVoidRequest storedValueVoidRequest = default, RequestOptions requestOptions = default)
        {
            return VoidTransactionAsync(storedValueVoidRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.StoredValue.StoredValueVoidResponse> VoidTransactionAsync(StoredValueVoidRequest storedValueVoidRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/voidTransaction";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.StoredValue.StoredValueVoidResponse>(storedValueVoidRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}