/*
* Adyen Payout API
*
*
* The version of the OpenAPI document: 68
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
using Adyen.Model;
using Adyen.Model.Payout;

namespace Adyen.Service.Payout
{
    /// <summary>
    /// ReviewingService Interface
    /// </summary>
    public interface IReviewingService
    {
        /// <summary>
        /// Confirm a payout
        /// </summary>
        /// <param name="modifyRequest"><see cref="ModifyRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ModifyResponse"/>.</returns>
        Model.Payout.ModifyResponse ConfirmThirdParty(ModifyRequest modifyRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Confirm a payout
        /// </summary>
        /// <param name="modifyRequest"><see cref="ModifyRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ModifyResponse"/>.</returns>
        Task<Model.Payout.ModifyResponse> ConfirmThirdPartyAsync(ModifyRequest modifyRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Cancel a payout
        /// </summary>
        /// <param name="modifyRequest"><see cref="ModifyRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ModifyResponse"/>.</returns>
        Model.Payout.ModifyResponse DeclineThirdParty(ModifyRequest modifyRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Cancel a payout
        /// </summary>
        /// <param name="modifyRequest"><see cref="ModifyRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ModifyResponse"/>.</returns>
        Task<Model.Payout.ModifyResponse> DeclineThirdPartyAsync(ModifyRequest modifyRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the ReviewingService API endpoints
    /// </summary>
    public class ReviewingService : AbstractService, IReviewingService
    {
        private readonly string _baseUrl;
        
        public ReviewingService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://pal-test.adyen.com/pal/servlet/Payout/v68");
        }
        
        public Model.Payout.ModifyResponse ConfirmThirdParty(ModifyRequest modifyRequest = default, RequestOptions requestOptions = default)
        {
            return ConfirmThirdPartyAsync(modifyRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Payout.ModifyResponse> ConfirmThirdPartyAsync(ModifyRequest modifyRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/confirmThirdParty";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Payout.ModifyResponse>(modifyRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Payout.ModifyResponse DeclineThirdParty(ModifyRequest modifyRequest = default, RequestOptions requestOptions = default)
        {
            return DeclineThirdPartyAsync(modifyRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Payout.ModifyResponse> DeclineThirdPartyAsync(ModifyRequest modifyRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/declineThirdParty";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Payout.ModifyResponse>(modifyRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}