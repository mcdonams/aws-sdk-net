/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Route53.Model;
using Amazon.Route53.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Route53
{
    /// <summary>
    /// Implementation for accessing Route53
    ///
    /// 
    /// </summary>
    public partial class AmazonRoute53Client : AmazonServiceClient, IAmazonRoute53
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonRoute53Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonRoute53Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53Config()) { }

        /// <summary>
        /// Constructs AmazonRoute53Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRoute53Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonRoute53Client Configuration Object</param>
        public AmazonRoute53Client(AmazonRoute53Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRoute53Client(AWSCredentials credentials)
            : this(credentials, new AmazonRoute53Config())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRoute53Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Credentials and an
        /// AmazonRoute53Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRoute53Client Configuration Object</param>
        public AmazonRoute53Client(AWSCredentials credentials, AmazonRoute53Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53Config())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRoute53Client Configuration Object</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonRoute53Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53Config())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRoute53Client Configuration Object</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRoute53Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.Route53.Internal.AmazonRoute53PostMarshallHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.ErrorCallbackHandler>(new Amazon.Route53.Internal.AmazonRoute53PreMarshallHandler());
        }    

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AssociateVPCWithHostedZone


        /// <summary>
        /// This action associates a VPC with an hosted zone. 
        /// 
        ///  
        /// <para>
        /// To associate a VPC with an hosted zone, send a <code>POST</code> request to the <code>/<i>Route
        /// 53 API version</i>/hostedzone/<i>hosted zone ID</i>/associatevpc</code> resource.
        /// The request body must include a document with a <code>AssociateVPCWithHostedZoneRequest</code>
        /// element. The response returns the <code>AssociateVPCWithHostedZoneResponse</code>
        /// element that contains <code>ChangeInfo</code> for you to track the progress of the
        /// <code>AssociateVPCWithHostedZoneRequest</code> you made. See <code>GetChange</code>
        /// operation for how to track the progress of your change.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVPCWithHostedZone service method.</param>
        /// 
        /// <returns>The response from the AssociateVPCWithHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConflictingDomainExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidVPCIdException">
        /// The hosted zone you are trying to create for your VPC_ID does not belong to you. Amazon
        /// Route 53 returns this error when the VPC specified by <code>VPCId</code> does not
        /// belong to you.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.LimitsExceededException">
        /// The limits specified for a resource have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PublicZoneVPCAssociationException">
        /// The hosted zone you are trying to associate VPC with doesn't have any VPC association.
        /// Amazon Route 53 currently doesn't support associate a VPC with a public hosted zone.
        /// </exception>
        public AssociateVPCWithHostedZoneResponse AssociateVPCWithHostedZone(AssociateVPCWithHostedZoneRequest request)
        {
            var marshaller = new AssociateVPCWithHostedZoneRequestMarshaller();
            var unmarshaller = AssociateVPCWithHostedZoneResponseUnmarshaller.Instance;

            return Invoke<AssociateVPCWithHostedZoneRequest,AssociateVPCWithHostedZoneResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateVPCWithHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateVPCWithHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AssociateVPCWithHostedZoneResponse> AssociateVPCWithHostedZoneAsync(AssociateVPCWithHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateVPCWithHostedZoneRequestMarshaller();
            var unmarshaller = AssociateVPCWithHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateVPCWithHostedZoneRequest,AssociateVPCWithHostedZoneResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ChangeResourceRecordSets


        /// <summary>
        /// Use this action to create or change your authoritative DNS information. To use this
        /// action, send a <code>POST</code> request to the <code>/<i>Route 53 API version</i>/hostedzone/<i>hosted
        /// Zone ID</i>/rrset</code> resource. The request body must include a document with a
        /// <code>ChangeResourceRecordSetsRequest</code> element.
        /// 
        ///  
        /// <para>
        /// Changes are a list of change items and are considered transactional. For more information
        /// on transactional changes, also known as change batches, see <a href="http://docs.aws.amazon.com/Route53/latest/APIReference/API_ChangeResourceRecordSets.html">POST
        /// ChangeResourceRecordSets</a> in the <i>Amazon Route 53 API Reference</i>.
        /// </para>
        ///  <important>Due to the nature of transactional changes, you cannot delete the same
        /// resource record set more than once in a single change batch. If you attempt to delete
        /// the same change batch more than once, Amazon Route 53 returns an <code>InvalidChangeBatch</code>
        /// error.</important> 
        /// <para>
        /// In response to a <code>ChangeResourceRecordSets</code> request, your DNS data is changed
        /// on all Amazon Route 53 DNS servers. Initially, the status of a change is <code>PENDING</code>.
        /// This means the change has not yet propagated to all the authoritative Amazon Route
        /// 53 DNS servers. When the change is propagated to all hosts, the change returns a status
        /// of <code>INSYNC</code>.
        /// </para>
        ///  
        /// <para>
        /// Note the following limitations on a <code>ChangeResourceRecordSets</code> request:
        /// </para>
        ///  <ul> <li>A request cannot contain more than 100 Change elements.</li> <li> A request
        /// cannot contain more than 1000 ResourceRecord elements.</li> <li>The sum of the number
        /// of characters (including spaces) in all <code>Value</code> elements in a request cannot
        /// exceed 32,000 characters.</li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeResourceRecordSets service method.</param>
        /// 
        /// <returns>The response from the ChangeResourceRecordSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidChangeBatchException">
        /// This error contains a list of one or more error messages. Each error message indicates
        /// one error in the change batch. For more information, see <a href="http://docs.aws.amazon.com/Route53/latest/APIReference/API_ChangeResourceRecordSets.html#example_Errors">Example
        /// InvalidChangeBatch Errors</a>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Amazon Route 53 was still processing a prior request.
        /// </exception>
        public ChangeResourceRecordSetsResponse ChangeResourceRecordSets(ChangeResourceRecordSetsRequest request)
        {
            var marshaller = new ChangeResourceRecordSetsRequestMarshaller();
            var unmarshaller = ChangeResourceRecordSetsResponseUnmarshaller.Instance;

            return Invoke<ChangeResourceRecordSetsRequest,ChangeResourceRecordSetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeResourceRecordSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeResourceRecordSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ChangeResourceRecordSetsResponse> ChangeResourceRecordSetsAsync(ChangeResourceRecordSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ChangeResourceRecordSetsRequestMarshaller();
            var unmarshaller = ChangeResourceRecordSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ChangeResourceRecordSetsRequest,ChangeResourceRecordSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ChangeTagsForResource


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ChangeTagsForResource service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Amazon Route 53 was still processing a prior request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.ThrottlingException">
        /// 
        /// </exception>
        public ChangeTagsForResourceResponse ChangeTagsForResource(ChangeTagsForResourceRequest request)
        {
            var marshaller = new ChangeTagsForResourceRequestMarshaller();
            var unmarshaller = ChangeTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ChangeTagsForResourceRequest,ChangeTagsForResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ChangeTagsForResourceResponse> ChangeTagsForResourceAsync(ChangeTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ChangeTagsForResourceRequestMarshaller();
            var unmarshaller = ChangeTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ChangeTagsForResourceRequest,ChangeTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateHealthCheck


        /// <summary>
        /// This action creates a new health check.
        /// 
        ///  
        /// <para>
        /// To create a new health check, send a <code>POST</code> request to the <code>/<i>Route
        /// 53 API version</i>/healthcheck</code> resource. The request body must include a document
        /// with a <code>CreateHealthCheckRequest</code> element. The response returns the <code>CreateHealthCheckResponse</code>
        /// element that contains metadata about the health check.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHealthCheck service method.</param>
        /// 
        /// <returns>The response from the CreateHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HealthCheckAlreadyExistsException">
        /// The health check you are trying to create already exists. Amazon Route 53 returns
        /// this error when a health check has already been created with the specified <code>CallerReference</code>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TooManyHealthChecksException">
        /// 
        /// </exception>
        public CreateHealthCheckResponse CreateHealthCheck(CreateHealthCheckRequest request)
        {
            var marshaller = new CreateHealthCheckRequestMarshaller();
            var unmarshaller = CreateHealthCheckResponseUnmarshaller.Instance;

            return Invoke<CreateHealthCheckRequest,CreateHealthCheckResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateHealthCheckResponse> CreateHealthCheckAsync(CreateHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateHealthCheckRequestMarshaller();
            var unmarshaller = CreateHealthCheckResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHealthCheckRequest,CreateHealthCheckResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateHostedZone


        /// <summary>
        /// This action creates a new hosted zone.
        /// 
        ///  
        /// <para>
        /// To create a new hosted zone, send a <code>POST</code> request to the <code>/<i>Route
        /// 53 API version</i>/hostedzone</code> resource. The request body must include a document
        /// with a <code>CreateHostedZoneRequest</code> element. The response returns the <code>CreateHostedZoneResponse</code>
        /// element that contains metadata about the hosted zone.
        /// </para>
        ///  
        /// <para>
        /// Amazon Route 53 automatically creates a default SOA record and four NS records for
        /// the zone. The NS records in the hosted zone are the name servers you give your registrar
        /// to delegate your domain to. For more information about SOA and NS records, see <a
        /// href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/SOA-NSrecords.html">NS
        /// and SOA Records that Amazon Route 53 Creates for a Hosted Zone</a> in the <i>Amazon
        /// Route 53 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you create a zone, its initial status is <code>PENDING</code>. This means that
        /// it is not yet available on all DNS servers. The status of the zone changes to <code>INSYNC</code>
        /// when the NS and SOA records are available on all Amazon Route 53 DNS servers. 
        /// </para>
        ///  
        /// <para>
        /// When trying to create a hosted zone using a reusable delegation set, you could specify
        /// an optional DelegationSetId, and Route53 would assign those 4 NS records for the zone,
        /// instead of alloting a new one.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHostedZone service method.</param>
        /// 
        /// <returns>The response from the CreateHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConflictingDomainExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotAvailableException">
        /// Amazon Route 53 allows some duplicate domain names, but there is a maximum number
        /// of duplicate names. This error indicates that you have reached that maximum. If you
        /// want to create another hosted zone with the same name and Amazon Route 53 generates
        /// this error, you can request an increase to the limit on the <a href="http://aws.amazon.com/route53-request/">Contact
        /// Us</a> page.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// The specified delegation set has not been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.HostedZoneAlreadyExistsException">
        /// The hosted zone you are trying to create already exists. Amazon Route 53 returns this
        /// error when a hosted zone has already been created with the specified <code>CallerReference</code>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidDomainNameException">
        /// This error indicates that the specified domain name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidVPCIdException">
        /// The hosted zone you are trying to create for your VPC_ID does not belong to you. Amazon
        /// Route 53 returns this error when the VPC specified by <code>VPCId</code> does not
        /// belong to you.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// The specified delegation set does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TooManyHostedZonesException">
        /// This error indicates that you've reached the maximum number of hosted zones that can
        /// be created for the current AWS account. You can request an increase to the limit on
        /// the <a href="http://aws.amazon.com/route53-request/">Contact Us</a> page.
        /// </exception>
        public CreateHostedZoneResponse CreateHostedZone(CreateHostedZoneRequest request)
        {
            var marshaller = new CreateHostedZoneRequestMarshaller();
            var unmarshaller = CreateHostedZoneResponseUnmarshaller.Instance;

            return Invoke<CreateHostedZoneRequest,CreateHostedZoneResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateHostedZoneResponse> CreateHostedZoneAsync(CreateHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateHostedZoneRequestMarshaller();
            var unmarshaller = CreateHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHostedZoneRequest,CreateHostedZoneResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateReusableDelegationSet


        /// <summary>
        /// This action creates a reusable delegationSet.
        /// 
        ///  
        /// <para>
        /// To create a new reusable delegationSet, send a <code>POST</code> request to the <code>/<i>Route
        /// 53 API version</i>/delegationset</code> resource. The request body must include a
        /// document with a <code>CreateReusableDelegationSetRequest</code> element. The response
        /// returns the <code>CreateReusableDelegationSetResponse</code> element that contains
        /// metadata about the delegationSet. 
        /// </para>
        ///  
        /// <para>
        /// If the optional parameter HostedZoneId is specified, it marks the delegationSet associated
        /// with that particular hosted zone as reusable. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReusableDelegationSet service method.</param>
        /// 
        /// <returns>The response from the CreateReusableDelegationSet service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetAlreadyCreatedException">
        /// A delegation set with the same owner and caller reference combination has already
        /// been created.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetAlreadyReusableException">
        /// The specified delegation set has already been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotAvailableException">
        /// Amazon Route 53 allows some duplicate domain names, but there is a maximum number
        /// of duplicate names. This error indicates that you have reached that maximum. If you
        /// want to create another hosted zone with the same name and Amazon Route 53 generates
        /// this error, you can request an increase to the limit on the <a href="http://aws.amazon.com/route53-request/">Contact
        /// Us</a> page.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.HostedZoneNotFoundException">
        /// The specified HostedZone cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidArgumentException">
        /// At least one of the specified arguments is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.LimitsExceededException">
        /// The limits specified for a resource have been exceeded.
        /// </exception>
        public CreateReusableDelegationSetResponse CreateReusableDelegationSet(CreateReusableDelegationSetRequest request)
        {
            var marshaller = new CreateReusableDelegationSetRequestMarshaller();
            var unmarshaller = CreateReusableDelegationSetResponseUnmarshaller.Instance;

            return Invoke<CreateReusableDelegationSetRequest,CreateReusableDelegationSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReusableDelegationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateReusableDelegationSetResponse> CreateReusableDelegationSetAsync(CreateReusableDelegationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateReusableDelegationSetRequestMarshaller();
            var unmarshaller = CreateReusableDelegationSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReusableDelegationSetRequest,CreateReusableDelegationSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTrafficPolicy


        /// <summary>
        /// Creates a traffic policy, which you use to create multiple DNS resource record sets
        /// for one domain name (such as example.com) or one subdomain name (such as www.example.com).
        /// 
        ///  
        /// <para>
        /// To create a traffic policy, send a <code>POST</code> request to the <code>/<i>Route
        /// 53 API version</i>/trafficpolicy</code> resource. The request body must include a
        /// document with a <code>CreateTrafficPolicyRequest</code> element. The response includes
        /// the <code>CreateTrafficPolicyResponse</code> element, which contains information about
        /// the new traffic policy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateTrafficPolicy service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidTrafficPolicyDocumentException">
        /// The format of the traffic policy document that you specified in the <code>Document</code>
        /// element is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TooManyTrafficPoliciesException">
        /// You've created the maximum number of traffic policies that can be created for the
        /// current AWS account. You can request an increase to the limit on the <a href="http://aws.amazon.com/route53-request/">Contact
        /// Us</a> page.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TrafficPolicyAlreadyExistsException">
        /// A traffic policy that has the same value for <code>Name</code> already exists.
        /// </exception>
        public CreateTrafficPolicyResponse CreateTrafficPolicy(CreateTrafficPolicyRequest request)
        {
            var marshaller = new CreateTrafficPolicyRequestMarshaller();
            var unmarshaller = CreateTrafficPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateTrafficPolicyRequest,CreateTrafficPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateTrafficPolicyResponse> CreateTrafficPolicyAsync(CreateTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTrafficPolicyRequestMarshaller();
            var unmarshaller = CreateTrafficPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrafficPolicyRequest,CreateTrafficPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTrafficPolicyInstance


        /// <summary>
        /// Creates resource record sets in a specified hosted zone based on the settings in a
        /// specified traffic policy version. In addition, <code>CreateTrafficPolicyInstance</code>
        /// associates the resource record sets with a specified domain name (such as example.com)
        /// or subdomain name (such as www.example.com). Amazon Route 53 responds to DNS queries
        /// for the domain or subdomain name by using the resource record sets that <code>CreateTrafficPolicyInstance</code>
        /// created.
        /// 
        ///  
        /// <para>
        /// To create a traffic policy instance, send a <code>POST</code> request to the <code>/<i>Route
        /// 53 API version</i>/trafficpolicyinstance</code> resource. The request body must include
        /// a document with a <code>CreateTrafficPolicyRequest</code> element. The response returns
        /// the <code>CreateTrafficPolicyInstanceResponse</code> element, which contains information
        /// about the traffic policy instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicyInstance service method.</param>
        /// 
        /// <returns>The response from the CreateTrafficPolicyInstance service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TooManyTrafficPolicyInstancesException">
        /// You've created the maximum number of traffic policy instances that can be created
        /// for the current AWS account. You can request an increase to the limit on the <a href="http://aws.amazon.com/route53-request/">Contact
        /// Us</a> page.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TrafficPolicyInstanceAlreadyExistsException">
        /// Traffic policy instance with given Id already exists.
        /// </exception>
        public CreateTrafficPolicyInstanceResponse CreateTrafficPolicyInstance(CreateTrafficPolicyInstanceRequest request)
        {
            var marshaller = new CreateTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = CreateTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateTrafficPolicyInstanceRequest,CreateTrafficPolicyInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicyInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateTrafficPolicyInstanceResponse> CreateTrafficPolicyInstanceAsync(CreateTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = CreateTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrafficPolicyInstanceRequest,CreateTrafficPolicyInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTrafficPolicyVersion


        /// <summary>
        /// Creates a new version of an existing traffic policy. When you create a new version
        /// of a traffic policy, you specify the ID of the traffic policy that you want to update
        /// and a JSON-formatted document that describes the new version.
        /// 
        ///  
        /// <para>
        /// You use traffic policies to create multiple DNS resource record sets for one domain
        /// name (such as example.com) or one subdomain name (such as www.example.com).
        /// </para>
        ///  
        /// <para>
        /// To create a new version, send a <code>POST</code> request to the <code>/<i>Route 53
        /// API version</i>/trafficpolicy/</code> resource. The request body includes a document
        /// with a <code>CreateTrafficPolicyVersionRequest</code> element. The response returns
        /// the <code>CreateTrafficPolicyVersionResponse</code> element, which contains information
        /// about the new version of the traffic policy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicyVersion service method.</param>
        /// 
        /// <returns>The response from the CreateTrafficPolicyVersion service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to update the object at the same time that you did.
        /// Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidTrafficPolicyDocumentException">
        /// The format of the traffic policy document that you specified in the <code>Document</code>
        /// element is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        public CreateTrafficPolicyVersionResponse CreateTrafficPolicyVersion(CreateTrafficPolicyVersionRequest request)
        {
            var marshaller = new CreateTrafficPolicyVersionRequestMarshaller();
            var unmarshaller = CreateTrafficPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<CreateTrafficPolicyVersionRequest,CreateTrafficPolicyVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrafficPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicyVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateTrafficPolicyVersionResponse> CreateTrafficPolicyVersionAsync(CreateTrafficPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTrafficPolicyVersionRequestMarshaller();
            var unmarshaller = CreateTrafficPolicyVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrafficPolicyVersionRequest,CreateTrafficPolicyVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteHealthCheck


        /// <summary>
        /// This action deletes a health check. To delete a health check, send a <code>DELETE</code>
        /// request to the <code>/<i>Route 53 API version</i>/healthcheck/<i>health check ID</i></code>
        /// resource.
        /// 
        ///  <important> You can delete a health check only if there are no resource record sets
        /// associated with this health check. If resource record sets are associated with this
        /// health check, you must disassociate them before you can delete your health check.
        /// If you try to delete a health check that is associated with resource record sets,
        /// Amazon Route 53 will deny your request with a <code>HealthCheckInUse</code> error.
        /// For information about disassociating the records from your health check, see <a>ChangeResourceRecordSets</a>.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHealthCheck service method.</param>
        /// 
        /// <returns>The response from the DeleteHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HealthCheckInUseException">
        /// There are resource records associated with this health check. Before you can delete
        /// the health check, you must disassociate it from the resource record sets.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        public DeleteHealthCheckResponse DeleteHealthCheck(DeleteHealthCheckRequest request)
        {
            var marshaller = new DeleteHealthCheckRequestMarshaller();
            var unmarshaller = DeleteHealthCheckResponseUnmarshaller.Instance;

            return Invoke<DeleteHealthCheckRequest,DeleteHealthCheckResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteHealthCheckResponse> DeleteHealthCheckAsync(DeleteHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteHealthCheckRequestMarshaller();
            var unmarshaller = DeleteHealthCheckResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHealthCheckRequest,DeleteHealthCheckResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteHostedZone


        /// <summary>
        /// This action deletes a hosted zone. To delete a hosted zone, send a <code>DELETE</code>
        /// request to the <code>/<i>Route 53 API version</i>/hostedzone/<i>hosted zone ID</i></code>
        /// resource.
        /// 
        ///  
        /// <para>
        /// For more information about deleting a hosted zone, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DeleteHostedZone.html">Deleting
        /// a Hosted Zone</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  <important> You can delete a hosted zone only if there are no resource record sets
        /// other than the default SOA record and NS resource record sets. If your hosted zone
        /// contains other resource record sets, you must delete them before you can delete your
        /// hosted zone. If you try to delete a hosted zone that contains other resource record
        /// sets, Amazon Route 53 will deny your request with a <code>HostedZoneNotEmpty</code>
        /// error. For information about deleting records from your hosted zone, see <a>ChangeResourceRecordSets</a>.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostedZone service method.</param>
        /// 
        /// <returns>The response from the DeleteHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HostedZoneNotEmptyException">
        /// The hosted zone contains resource record sets in addition to the default NS and SOA
        /// resource record sets. Before you can delete the hosted zone, you must delete the additional
        /// resource record sets.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Amazon Route 53 was still processing a prior request.
        /// </exception>
        public DeleteHostedZoneResponse DeleteHostedZone(DeleteHostedZoneRequest request)
        {
            var marshaller = new DeleteHostedZoneRequestMarshaller();
            var unmarshaller = DeleteHostedZoneResponseUnmarshaller.Instance;

            return Invoke<DeleteHostedZoneRequest,DeleteHostedZoneResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteHostedZoneResponse> DeleteHostedZoneAsync(DeleteHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteHostedZoneRequestMarshaller();
            var unmarshaller = DeleteHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHostedZoneRequest,DeleteHostedZoneResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteReusableDelegationSet


        /// <summary>
        /// This action deletes a reusable delegation set. To delete a reusable delegation set,
        /// send a <code>DELETE</code> request to the <code>/<i>Route 53 API version</i>/delegationset/<i>delegation
        /// set ID</i></code> resource.
        /// 
        ///  <important> You can delete a reusable delegation set only if there are no associated
        /// hosted zones. If your reusable delegation set contains associated hosted zones, you
        /// must delete them before you can delete your reusable delegation set. If you try to
        /// delete a reusable delegation set that contains associated hosted zones, Amazon Route
        /// 53 will deny your request with a <code>DelegationSetInUse</code> error.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReusableDelegationSet service method.</param>
        /// 
        /// <returns>The response from the DeleteReusableDelegationSet service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetInUseException">
        /// The specified delegation contains associated hosted zones which must be deleted before
        /// the reusable delegation set can be deleted.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// The specified delegation set has not been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// The specified delegation set does not exist.
        /// </exception>
        public DeleteReusableDelegationSetResponse DeleteReusableDelegationSet(DeleteReusableDelegationSetRequest request)
        {
            var marshaller = new DeleteReusableDelegationSetRequestMarshaller();
            var unmarshaller = DeleteReusableDelegationSetResponseUnmarshaller.Instance;

            return Invoke<DeleteReusableDelegationSetRequest,DeleteReusableDelegationSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReusableDelegationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteReusableDelegationSetResponse> DeleteReusableDelegationSetAsync(DeleteReusableDelegationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteReusableDelegationSetRequestMarshaller();
            var unmarshaller = DeleteReusableDelegationSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReusableDelegationSetRequest,DeleteReusableDelegationSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrafficPolicy


        /// <summary>
        /// Deletes a traffic policy. To delete a traffic policy, send a <code>DELETE</code> request
        /// to the <code>/<i>Route 53 API version</i>/trafficpolicy</code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteTrafficPolicy service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to update the object at the same time that you did.
        /// Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TrafficPolicyInUseException">
        /// One or more traffic policy instances were created by using the specified traffic policy.
        /// </exception>
        public DeleteTrafficPolicyResponse DeleteTrafficPolicy(DeleteTrafficPolicyRequest request)
        {
            var marshaller = new DeleteTrafficPolicyRequestMarshaller();
            var unmarshaller = DeleteTrafficPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteTrafficPolicyRequest,DeleteTrafficPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteTrafficPolicyResponse> DeleteTrafficPolicyAsync(DeleteTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTrafficPolicyRequestMarshaller();
            var unmarshaller = DeleteTrafficPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrafficPolicyRequest,DeleteTrafficPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrafficPolicyInstance


        /// <summary>
        /// Deletes a traffic policy instance and all of the resource record sets that Amazon
        /// Route 53 created when you created the instance.
        /// 
        ///  
        /// <para>
        /// To delete a traffic policy instance, send a <code>DELETE</code> request to the <code>/<i>Route
        /// 53 API version</i>/trafficpolicy/<i>traffic policy instance ID</i></code> resource.
        /// </para>
        ///  <important>When you delete a traffic policy instance, Amazon Route 53 also deletes
        /// all of the resource record sets that were created when you created the traffic policy
        /// instance.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicyInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteTrafficPolicyInstance service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyInstanceException">
        /// No traffic policy instance exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Amazon Route 53 was still processing a prior request.
        /// </exception>
        public DeleteTrafficPolicyInstanceResponse DeleteTrafficPolicyInstance(DeleteTrafficPolicyInstanceRequest request)
        {
            var marshaller = new DeleteTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = DeleteTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteTrafficPolicyInstanceRequest,DeleteTrafficPolicyInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicyInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteTrafficPolicyInstanceResponse> DeleteTrafficPolicyInstanceAsync(DeleteTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = DeleteTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrafficPolicyInstanceRequest,DeleteTrafficPolicyInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateVPCFromHostedZone


        /// <summary>
        /// This action disassociates a VPC from an hosted zone. 
        /// 
        ///  
        /// <para>
        /// To disassociate a VPC to a hosted zone, send a <code>POST</code> request to the <code>/<i>Route
        /// 53 API version</i>/hostedzone/<i>hosted zone ID</i>/disassociatevpc</code> resource.
        /// The request body must include a document with a <code>DisassociateVPCFromHostedZoneRequest</code>
        /// element. The response returns the <code>DisassociateVPCFromHostedZoneResponse</code>
        /// element that contains <code>ChangeInfo</code> for you to track the progress of the
        /// <code>DisassociateVPCFromHostedZoneRequest</code> you made. See <code>GetChange</code>
        /// operation for how to track the progress of your change.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVPCFromHostedZone service method.</param>
        /// 
        /// <returns>The response from the DisassociateVPCFromHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidVPCIdException">
        /// The hosted zone you are trying to create for your VPC_ID does not belong to you. Amazon
        /// Route 53 returns this error when the VPC specified by <code>VPCId</code> does not
        /// belong to you.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.LastVPCAssociationException">
        /// The VPC you are trying to disassociate from the hosted zone is the last the VPC that
        /// is associated with the hosted zone. Amazon Route 53 currently doesn't support disassociate
        /// the last VPC from the hosted zone.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.VPCAssociationNotFoundException">
        /// The VPC you specified is not currently associated with the hosted zone.
        /// </exception>
        public DisassociateVPCFromHostedZoneResponse DisassociateVPCFromHostedZone(DisassociateVPCFromHostedZoneRequest request)
        {
            var marshaller = new DisassociateVPCFromHostedZoneRequestMarshaller();
            var unmarshaller = DisassociateVPCFromHostedZoneResponseUnmarshaller.Instance;

            return Invoke<DisassociateVPCFromHostedZoneRequest,DisassociateVPCFromHostedZoneResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateVPCFromHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVPCFromHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DisassociateVPCFromHostedZoneResponse> DisassociateVPCFromHostedZoneAsync(DisassociateVPCFromHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisassociateVPCFromHostedZoneRequestMarshaller();
            var unmarshaller = DisassociateVPCFromHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateVPCFromHostedZoneRequest,DisassociateVPCFromHostedZoneResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetChange


        /// <summary>
        /// This action returns the current status of a change batch request. The status is one
        /// of the following values:
        /// 
        ///  
        /// <para>
        /// - <code>PENDING</code> indicates that the changes in this request have not replicated
        /// to all Amazon Route 53 DNS servers. This is the initial status of all change batch
        /// requests.
        /// </para>
        ///  
        /// <para>
        /// - <code>INSYNC</code> indicates that the changes have replicated to all Amazon Route
        /// 53 DNS servers. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChange service method.</param>
        /// 
        /// <returns>The response from the GetChange service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchChangeException">
        /// 
        /// </exception>
        public GetChangeResponse GetChange(GetChangeRequest request)
        {
            var marshaller = new GetChangeRequestMarshaller();
            var unmarshaller = GetChangeResponseUnmarshaller.Instance;

            return Invoke<GetChangeRequest,GetChangeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetChange operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChange operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetChangeResponse> GetChangeAsync(GetChangeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetChangeRequestMarshaller();
            var unmarshaller = GetChangeResponseUnmarshaller.Instance;

            return InvokeAsync<GetChangeRequest,GetChangeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetChangeDetails


        /// <summary>
        /// This action returns the status and changes of a change batch request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeDetails service method.</param>
        /// 
        /// <returns>The response from the GetChangeDetails service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchChangeException">
        /// 
        /// </exception>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        public GetChangeDetailsResponse GetChangeDetails(GetChangeDetailsRequest request)
        {
            var marshaller = new GetChangeDetailsRequestMarshaller();
            var unmarshaller = GetChangeDetailsResponseUnmarshaller.Instance;

            return Invoke<GetChangeDetailsRequest,GetChangeDetailsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetChangeDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChangeDetails operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        public Task<GetChangeDetailsResponse> GetChangeDetailsAsync(GetChangeDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetChangeDetailsRequestMarshaller();
            var unmarshaller = GetChangeDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetChangeDetailsRequest,GetChangeDetailsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCheckerIpRanges


        /// <summary>
        /// To retrieve a list of the IP ranges used by Amazon Route 53 health checkers to check
        /// the health of your resources, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/checkeripranges</code> resource. You can use these IP addresses
        /// to configure router and firewall rules to allow health checkers to check the health
        /// of your resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCheckerIpRanges service method.</param>
        /// 
        /// <returns>The response from the GetCheckerIpRanges service method, as returned by Route53.</returns>
        public GetCheckerIpRangesResponse GetCheckerIpRanges(GetCheckerIpRangesRequest request)
        {
            var marshaller = new GetCheckerIpRangesRequestMarshaller();
            var unmarshaller = GetCheckerIpRangesResponseUnmarshaller.Instance;

            return Invoke<GetCheckerIpRangesRequest,GetCheckerIpRangesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCheckerIpRanges operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCheckerIpRanges operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetCheckerIpRangesResponse> GetCheckerIpRangesAsync(GetCheckerIpRangesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCheckerIpRangesRequestMarshaller();
            var unmarshaller = GetCheckerIpRangesResponseUnmarshaller.Instance;

            return InvokeAsync<GetCheckerIpRangesRequest,GetCheckerIpRangesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetGeoLocation


        /// <summary>
        /// To retrieve a single geo location, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/geolocation</code> resource with one of these options: continentcode
        /// | countrycode | countrycode and subdivisioncode.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeoLocation service method.</param>
        /// 
        /// <returns>The response from the GetGeoLocation service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchGeoLocationException">
        /// The geo location you are trying to get does not exist.
        /// </exception>
        public GetGeoLocationResponse GetGeoLocation(GetGeoLocationRequest request)
        {
            var marshaller = new GetGeoLocationRequestMarshaller();
            var unmarshaller = GetGeoLocationResponseUnmarshaller.Instance;

            return Invoke<GetGeoLocationRequest,GetGeoLocationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGeoLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGeoLocation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetGeoLocationResponse> GetGeoLocationAsync(GetGeoLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetGeoLocationRequestMarshaller();
            var unmarshaller = GetGeoLocationResponseUnmarshaller.Instance;

            return InvokeAsync<GetGeoLocationRequest,GetGeoLocationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHealthCheck


        /// <summary>
        /// To retrieve the health check, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/healthcheck/<i>health check ID</i></code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheck service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.IncompatibleVersionException">
        /// The resource you are trying to access is unsupported on this Amazon Route 53 endpoint.
        /// Please consider using a newer endpoint or a tool that does so.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        public GetHealthCheckResponse GetHealthCheck(GetHealthCheckRequest request)
        {
            var marshaller = new GetHealthCheckRequestMarshaller();
            var unmarshaller = GetHealthCheckResponseUnmarshaller.Instance;

            return Invoke<GetHealthCheckRequest,GetHealthCheckResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetHealthCheckResponse> GetHealthCheckAsync(GetHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetHealthCheckRequestMarshaller();
            var unmarshaller = GetHealthCheckResponseUnmarshaller.Instance;

            return InvokeAsync<GetHealthCheckRequest,GetHealthCheckResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHealthCheckCount


        /// <summary>
        /// To retrieve a count of all your health checks, send a <code>GET</code> request to
        /// the <code>/<i>Route 53 API version</i>/healthcheckcount</code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckCount service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheckCount service method, as returned by Route53.</returns>
        public GetHealthCheckCountResponse GetHealthCheckCount(GetHealthCheckCountRequest request)
        {
            var marshaller = new GetHealthCheckCountRequestMarshaller();
            var unmarshaller = GetHealthCheckCountResponseUnmarshaller.Instance;

            return Invoke<GetHealthCheckCountRequest,GetHealthCheckCountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckCount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetHealthCheckCountResponse> GetHealthCheckCountAsync(GetHealthCheckCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetHealthCheckCountRequestMarshaller();
            var unmarshaller = GetHealthCheckCountResponseUnmarshaller.Instance;

            return InvokeAsync<GetHealthCheckCountRequest,GetHealthCheckCountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHealthCheckLastFailureReason


        /// <summary>
        /// If you want to learn why a health check is currently failing or why it failed most
        /// recently (if at all), you can get the failure reason for the most recent failure.
        /// Send a <code>GET</code> request to the <code>/<i>Route 53 API version</i>/healthcheck/<i>health
        /// check ID</i>/lastfailurereason</code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckLastFailureReason service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheckLastFailureReason service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        public GetHealthCheckLastFailureReasonResponse GetHealthCheckLastFailureReason(GetHealthCheckLastFailureReasonRequest request)
        {
            var marshaller = new GetHealthCheckLastFailureReasonRequestMarshaller();
            var unmarshaller = GetHealthCheckLastFailureReasonResponseUnmarshaller.Instance;

            return Invoke<GetHealthCheckLastFailureReasonRequest,GetHealthCheckLastFailureReasonResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckLastFailureReason operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckLastFailureReason operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetHealthCheckLastFailureReasonResponse> GetHealthCheckLastFailureReasonAsync(GetHealthCheckLastFailureReasonRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetHealthCheckLastFailureReasonRequestMarshaller();
            var unmarshaller = GetHealthCheckLastFailureReasonResponseUnmarshaller.Instance;

            return InvokeAsync<GetHealthCheckLastFailureReasonRequest,GetHealthCheckLastFailureReasonResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHealthCheckStatus


        /// <summary>
        /// To retrieve the health check status, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/healthcheck/<i>health check ID</i>/status</code> resource. You
        /// can use this call to get a health check's current status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckStatus service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheckStatus service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        public GetHealthCheckStatusResponse GetHealthCheckStatus(GetHealthCheckStatusRequest request)
        {
            var marshaller = new GetHealthCheckStatusRequestMarshaller();
            var unmarshaller = GetHealthCheckStatusResponseUnmarshaller.Instance;

            return Invoke<GetHealthCheckStatusRequest,GetHealthCheckStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetHealthCheckStatusResponse> GetHealthCheckStatusAsync(GetHealthCheckStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetHealthCheckStatusRequestMarshaller();
            var unmarshaller = GetHealthCheckStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetHealthCheckStatusRequest,GetHealthCheckStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHostedZone


        /// <summary>
        /// To retrieve the delegation set for a hosted zone, send a <code>GET</code> request
        /// to the <code>/<i>Route 53 API version</i>/hostedzone/<i>hosted zone ID</i></code>
        /// resource. The delegation set is the four Amazon Route 53 name servers that were assigned
        /// to the hosted zone when you created it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZone service method.</param>
        /// 
        /// <returns>The response from the GetHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        public GetHostedZoneResponse GetHostedZone(GetHostedZoneRequest request)
        {
            var marshaller = new GetHostedZoneRequestMarshaller();
            var unmarshaller = GetHostedZoneResponseUnmarshaller.Instance;

            return Invoke<GetHostedZoneRequest,GetHostedZoneResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetHostedZoneResponse> GetHostedZoneAsync(GetHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetHostedZoneRequestMarshaller();
            var unmarshaller = GetHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<GetHostedZoneRequest,GetHostedZoneResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHostedZoneCount


        /// <summary>
        /// To retrieve a count of all your hosted zones, send a <code>GET</code> request to the
        /// <code>/<i>Route 53 API version</i>/hostedzonecount</code> resource.
        /// </summary>
        /// 
        /// <returns>The response from the GetHostedZoneCount service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public GetHostedZoneCountResponse GetHostedZoneCount()
        {
            return GetHostedZoneCount(new GetHostedZoneCountRequest());
        }


        /// <summary>
        /// To retrieve a count of all your hosted zones, send a <code>GET</code> request to the
        /// <code>/<i>Route 53 API version</i>/hostedzonecount</code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZoneCount service method.</param>
        /// 
        /// <returns>The response from the GetHostedZoneCount service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public GetHostedZoneCountResponse GetHostedZoneCount(GetHostedZoneCountRequest request)
        {
            var marshaller = new GetHostedZoneCountRequestMarshaller();
            var unmarshaller = GetHostedZoneCountResponseUnmarshaller.Instance;

            return Invoke<GetHostedZoneCountRequest,GetHostedZoneCountResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// To retrieve a count of all your hosted zones, send a <code>GET</code> request to the
        /// <code>/<i>Route 53 API version</i>/hostedzonecount</code> resource.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHostedZoneCount service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public Task<GetHostedZoneCountResponse> GetHostedZoneCountAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetHostedZoneCountAsync(new GetHostedZoneCountRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the GetHostedZoneCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZoneCount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetHostedZoneCountResponse> GetHostedZoneCountAsync(GetHostedZoneCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetHostedZoneCountRequestMarshaller();
            var unmarshaller = GetHostedZoneCountResponseUnmarshaller.Instance;

            return InvokeAsync<GetHostedZoneCountRequest,GetHostedZoneCountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetReusableDelegationSet


        /// <summary>
        /// To retrieve the reusable delegation set, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/delegationset/<i>delegation set ID</i></code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReusableDelegationSet service method.</param>
        /// 
        /// <returns>The response from the GetReusableDelegationSet service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// The specified delegation set has not been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// The specified delegation set does not exist.
        /// </exception>
        public GetReusableDelegationSetResponse GetReusableDelegationSet(GetReusableDelegationSetRequest request)
        {
            var marshaller = new GetReusableDelegationSetRequestMarshaller();
            var unmarshaller = GetReusableDelegationSetResponseUnmarshaller.Instance;

            return Invoke<GetReusableDelegationSetRequest,GetReusableDelegationSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReusableDelegationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetReusableDelegationSetResponse> GetReusableDelegationSetAsync(GetReusableDelegationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetReusableDelegationSetRequestMarshaller();
            var unmarshaller = GetReusableDelegationSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetReusableDelegationSetRequest,GetReusableDelegationSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTrafficPolicy


        /// <summary>
        /// Gets information about a specific traffic policy version. To get the information,
        /// send a <code>GET</code> request to the <code>/<i>Route 53 API version</i>/trafficpolicy</code>
        /// resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicy service method.</param>
        /// 
        /// <returns>The response from the GetTrafficPolicy service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        public GetTrafficPolicyResponse GetTrafficPolicy(GetTrafficPolicyRequest request)
        {
            var marshaller = new GetTrafficPolicyRequestMarshaller();
            var unmarshaller = GetTrafficPolicyResponseUnmarshaller.Instance;

            return Invoke<GetTrafficPolicyRequest,GetTrafficPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetTrafficPolicyResponse> GetTrafficPolicyAsync(GetTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTrafficPolicyRequestMarshaller();
            var unmarshaller = GetTrafficPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrafficPolicyRequest,GetTrafficPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTrafficPolicyInstance


        /// <summary>
        /// Gets information about a specified traffic policy instance.
        /// 
        ///  
        /// <para>
        /// To get information about the traffic policy instance, send a <code>GET</code> request
        /// to the <code>/<i>Route 53 API version</i>/trafficpolicyinstance</code> resource.
        /// </para>
        ///  <note>After you submit a <code>CreateTrafficPolicyInstance</code> or an <code>UpdateTrafficPolicyInstance</code>
        /// request, there's a brief delay while Amazon Route 53 creates the resource record sets
        /// that are specified in the traffic policy definition. For more information, see the
        /// <a>State</a> response element. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicyInstance service method.</param>
        /// 
        /// <returns>The response from the GetTrafficPolicyInstance service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyInstanceException">
        /// No traffic policy instance exists with the specified ID.
        /// </exception>
        public GetTrafficPolicyInstanceResponse GetTrafficPolicyInstance(GetTrafficPolicyInstanceRequest request)
        {
            var marshaller = new GetTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = GetTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return Invoke<GetTrafficPolicyInstanceRequest,GetTrafficPolicyInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicyInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetTrafficPolicyInstanceResponse> GetTrafficPolicyInstanceAsync(GetTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = GetTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrafficPolicyInstanceRequest,GetTrafficPolicyInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTrafficPolicyInstanceCount


        /// <summary>
        /// Gets the number of traffic policy instances that are associated with the current AWS
        /// account.
        /// 
        ///  
        /// <para>
        /// To get the number of traffic policy instances, send a <code>GET</code> request to
        /// the <code>/<i>Route 53 API version</i>/trafficpolicyinstancecount</code> resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicyInstanceCount service method.</param>
        /// 
        /// <returns>The response from the GetTrafficPolicyInstanceCount service method, as returned by Route53.</returns>
        public GetTrafficPolicyInstanceCountResponse GetTrafficPolicyInstanceCount(GetTrafficPolicyInstanceCountRequest request)
        {
            var marshaller = new GetTrafficPolicyInstanceCountRequestMarshaller();
            var unmarshaller = GetTrafficPolicyInstanceCountResponseUnmarshaller.Instance;

            return Invoke<GetTrafficPolicyInstanceCountRequest,GetTrafficPolicyInstanceCountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrafficPolicyInstanceCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicyInstanceCount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetTrafficPolicyInstanceCountResponse> GetTrafficPolicyInstanceCountAsync(GetTrafficPolicyInstanceCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTrafficPolicyInstanceCountRequestMarshaller();
            var unmarshaller = GetTrafficPolicyInstanceCountResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrafficPolicyInstanceCountRequest,GetTrafficPolicyInstanceCountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListChangeBatchesByHostedZone


        /// <summary>
        /// This action gets the list of ChangeBatches in a given time period for a given hosted
        /// zone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangeBatchesByHostedZone service method.</param>
        /// 
        /// <returns>The response from the ListChangeBatchesByHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        public ListChangeBatchesByHostedZoneResponse ListChangeBatchesByHostedZone(ListChangeBatchesByHostedZoneRequest request)
        {
            var marshaller = new ListChangeBatchesByHostedZoneRequestMarshaller();
            var unmarshaller = ListChangeBatchesByHostedZoneResponseUnmarshaller.Instance;

            return Invoke<ListChangeBatchesByHostedZoneRequest,ListChangeBatchesByHostedZoneResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChangeBatchesByHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChangeBatchesByHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        public Task<ListChangeBatchesByHostedZoneResponse> ListChangeBatchesByHostedZoneAsync(ListChangeBatchesByHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListChangeBatchesByHostedZoneRequestMarshaller();
            var unmarshaller = ListChangeBatchesByHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<ListChangeBatchesByHostedZoneRequest,ListChangeBatchesByHostedZoneResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListChangeBatchesByRRSet


        /// <summary>
        /// This action gets the list of ChangeBatches in a given time period for a given hosted
        /// zone and RRSet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangeBatchesByRRSet service method.</param>
        /// 
        /// <returns>The response from the ListChangeBatchesByRRSet service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        public ListChangeBatchesByRRSetResponse ListChangeBatchesByRRSet(ListChangeBatchesByRRSetRequest request)
        {
            var marshaller = new ListChangeBatchesByRRSetRequestMarshaller();
            var unmarshaller = ListChangeBatchesByRRSetResponseUnmarshaller.Instance;

            return Invoke<ListChangeBatchesByRRSetRequest,ListChangeBatchesByRRSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChangeBatchesByRRSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChangeBatchesByRRSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        public Task<ListChangeBatchesByRRSetResponse> ListChangeBatchesByRRSetAsync(ListChangeBatchesByRRSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListChangeBatchesByRRSetRequestMarshaller();
            var unmarshaller = ListChangeBatchesByRRSetResponseUnmarshaller.Instance;

            return InvokeAsync<ListChangeBatchesByRRSetRequest,ListChangeBatchesByRRSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListGeoLocations


        /// <summary>
        /// To retrieve a list of supported geo locations, send a <code>GET</code> request to
        /// the <code>/<i>Route 53 API version</i>/geolocations</code> resource. The response
        /// to this request includes a <code>GeoLocationDetailsList</code> element with zero,
        /// one, or multiple <code>GeoLocationDetails</code> child elements. The list is sorted
        /// by country code, and then subdivision code, followed by continents at the end of the
        /// list. 
        /// 
        ///  
        /// <para>
        /// By default, the list of geo locations is displayed on a single page. You can control
        /// the length of the page that is displayed by using the <code>MaxItems</code> parameter.
        /// If the list is truncated, <code>IsTruncated</code> will be set to <i>true</i> and
        /// a combination of <code>NextContinentCode, NextCountryCode, NextSubdivisionCode</code>
        /// will be populated. You can pass these as parameters to <code>StartContinentCode, StartCountryCode,
        /// StartSubdivisionCode</code> to control the geo location that the list begins with.
        /// 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListGeoLocations service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public ListGeoLocationsResponse ListGeoLocations()
        {
            return ListGeoLocations(new ListGeoLocationsRequest());
        }


        /// <summary>
        /// To retrieve a list of supported geo locations, send a <code>GET</code> request to
        /// the <code>/<i>Route 53 API version</i>/geolocations</code> resource. The response
        /// to this request includes a <code>GeoLocationDetailsList</code> element with zero,
        /// one, or multiple <code>GeoLocationDetails</code> child elements. The list is sorted
        /// by country code, and then subdivision code, followed by continents at the end of the
        /// list. 
        /// 
        ///  
        /// <para>
        /// By default, the list of geo locations is displayed on a single page. You can control
        /// the length of the page that is displayed by using the <code>MaxItems</code> parameter.
        /// If the list is truncated, <code>IsTruncated</code> will be set to <i>true</i> and
        /// a combination of <code>NextContinentCode, NextCountryCode, NextSubdivisionCode</code>
        /// will be populated. You can pass these as parameters to <code>StartContinentCode, StartCountryCode,
        /// StartSubdivisionCode</code> to control the geo location that the list begins with.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeoLocations service method.</param>
        /// 
        /// <returns>The response from the ListGeoLocations service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public ListGeoLocationsResponse ListGeoLocations(ListGeoLocationsRequest request)
        {
            var marshaller = new ListGeoLocationsRequestMarshaller();
            var unmarshaller = ListGeoLocationsResponseUnmarshaller.Instance;

            return Invoke<ListGeoLocationsRequest,ListGeoLocationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// To retrieve a list of supported geo locations, send a <code>GET</code> request to
        /// the <code>/<i>Route 53 API version</i>/geolocations</code> resource. The response
        /// to this request includes a <code>GeoLocationDetailsList</code> element with zero,
        /// one, or multiple <code>GeoLocationDetails</code> child elements. The list is sorted
        /// by country code, and then subdivision code, followed by continents at the end of the
        /// list. 
        /// 
        ///  
        /// <para>
        /// By default, the list of geo locations is displayed on a single page. You can control
        /// the length of the page that is displayed by using the <code>MaxItems</code> parameter.
        /// If the list is truncated, <code>IsTruncated</code> will be set to <i>true</i> and
        /// a combination of <code>NextContinentCode, NextCountryCode, NextSubdivisionCode</code>
        /// will be populated. You can pass these as parameters to <code>StartContinentCode, StartCountryCode,
        /// StartSubdivisionCode</code> to control the geo location that the list begins with.
        /// 
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGeoLocations service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public Task<ListGeoLocationsResponse> ListGeoLocationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListGeoLocationsAsync(new ListGeoLocationsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the ListGeoLocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGeoLocations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListGeoLocationsResponse> ListGeoLocationsAsync(ListGeoLocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListGeoLocationsRequestMarshaller();
            var unmarshaller = ListGeoLocationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGeoLocationsRequest,ListGeoLocationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListHealthChecks


        /// <summary>
        /// To retrieve a list of your health checks, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/healthcheck</code> resource. The response to this request includes
        /// a <code>HealthChecks</code> element with zero, one, or multiple <code>HealthCheck</code>
        /// child elements. By default, the list of health checks is displayed on a single page.
        /// You can control the length of the page that is displayed by using the <code>MaxItems</code>
        /// parameter. You can use the <code>Marker</code> parameter to control the health check
        /// that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// 
        /// <returns>The response from the ListHealthChecks service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.IncompatibleVersionException">
        /// The resource you are trying to access is unsupported on this Amazon Route 53 endpoint.
        /// Please consider using a newer endpoint or a tool that does so.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public ListHealthChecksResponse ListHealthChecks()
        {
            return ListHealthChecks(new ListHealthChecksRequest());
        }


        /// <summary>
        /// To retrieve a list of your health checks, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/healthcheck</code> resource. The response to this request includes
        /// a <code>HealthChecks</code> element with zero, one, or multiple <code>HealthCheck</code>
        /// child elements. By default, the list of health checks is displayed on a single page.
        /// You can control the length of the page that is displayed by using the <code>MaxItems</code>
        /// parameter. You can use the <code>Marker</code> parameter to control the health check
        /// that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHealthChecks service method.</param>
        /// 
        /// <returns>The response from the ListHealthChecks service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.IncompatibleVersionException">
        /// The resource you are trying to access is unsupported on this Amazon Route 53 endpoint.
        /// Please consider using a newer endpoint or a tool that does so.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public ListHealthChecksResponse ListHealthChecks(ListHealthChecksRequest request)
        {
            var marshaller = new ListHealthChecksRequestMarshaller();
            var unmarshaller = ListHealthChecksResponseUnmarshaller.Instance;

            return Invoke<ListHealthChecksRequest,ListHealthChecksResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// To retrieve a list of your health checks, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/healthcheck</code> resource. The response to this request includes
        /// a <code>HealthChecks</code> element with zero, one, or multiple <code>HealthCheck</code>
        /// child elements. By default, the list of health checks is displayed on a single page.
        /// You can control the length of the page that is displayed by using the <code>MaxItems</code>
        /// parameter. You can use the <code>Marker</code> parameter to control the health check
        /// that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHealthChecks service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.IncompatibleVersionException">
        /// The resource you are trying to access is unsupported on this Amazon Route 53 endpoint.
        /// Please consider using a newer endpoint or a tool that does so.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public Task<ListHealthChecksResponse> ListHealthChecksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListHealthChecksAsync(new ListHealthChecksRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the ListHealthChecks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHealthChecks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListHealthChecksResponse> ListHealthChecksAsync(ListHealthChecksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListHealthChecksRequestMarshaller();
            var unmarshaller = ListHealthChecksResponseUnmarshaller.Instance;

            return InvokeAsync<ListHealthChecksRequest,ListHealthChecksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListHostedZones


        /// <summary>
        /// To retrieve a list of your hosted zones, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/hostedzone</code> resource. The response to this request includes
        /// a <code>HostedZones</code> element with zero, one, or multiple <code>HostedZone</code>
        /// child elements. By default, the list of hosted zones is displayed on a single page.
        /// You can control the length of the page that is displayed by using the <code>MaxItems</code>
        /// parameter. You can use the <code>Marker</code> parameter to control the hosted zone
        /// that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// 
        /// <returns>The response from the ListHostedZones service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// The specified delegation set has not been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// The specified delegation set does not exist.
        /// </exception>
        public ListHostedZonesResponse ListHostedZones()
        {
            return ListHostedZones(new ListHostedZonesRequest());
        }


        /// <summary>
        /// To retrieve a list of your hosted zones, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/hostedzone</code> resource. The response to this request includes
        /// a <code>HostedZones</code> element with zero, one, or multiple <code>HostedZone</code>
        /// child elements. By default, the list of hosted zones is displayed on a single page.
        /// You can control the length of the page that is displayed by using the <code>MaxItems</code>
        /// parameter. You can use the <code>Marker</code> parameter to control the hosted zone
        /// that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZones service method.</param>
        /// 
        /// <returns>The response from the ListHostedZones service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// The specified delegation set has not been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// The specified delegation set does not exist.
        /// </exception>
        public ListHostedZonesResponse ListHostedZones(ListHostedZonesRequest request)
        {
            var marshaller = new ListHostedZonesRequestMarshaller();
            var unmarshaller = ListHostedZonesResponseUnmarshaller.Instance;

            return Invoke<ListHostedZonesRequest,ListHostedZonesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// To retrieve a list of your hosted zones, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/hostedzone</code> resource. The response to this request includes
        /// a <code>HostedZones</code> element with zero, one, or multiple <code>HostedZone</code>
        /// child elements. By default, the list of hosted zones is displayed on a single page.
        /// You can control the length of the page that is displayed by using the <code>MaxItems</code>
        /// parameter. You can use the <code>Marker</code> parameter to control the hosted zone
        /// that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHostedZones service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// The specified delegation set has not been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// The specified delegation set does not exist.
        /// </exception>
        public Task<ListHostedZonesResponse> ListHostedZonesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListHostedZonesAsync(new ListHostedZonesRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the ListHostedZones operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZones operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListHostedZonesResponse> ListHostedZonesAsync(ListHostedZonesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListHostedZonesRequestMarshaller();
            var unmarshaller = ListHostedZonesResponseUnmarshaller.Instance;

            return InvokeAsync<ListHostedZonesRequest,ListHostedZonesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListHostedZonesByName


        /// <summary>
        /// To retrieve a list of your hosted zones in lexicographic order, send a <code>GET</code>
        /// request to the <code>/<i>Route 53 API version</i>/hostedzonesbyname</code> resource.
        /// The response to this request includes a <code>HostedZones</code> element with zero
        /// or more <code>HostedZone</code> child elements lexicographically ordered by DNS name.
        /// By default, the list of hosted zones is displayed on a single page. You can control
        /// the length of the page that is displayed by using the <code>MaxItems</code> parameter.
        /// You can use the <code>DNSName</code> and <code>HostedZoneId</code> parameters to control
        /// the hosted zone that the list begins with.
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZonesByName service method.</param>
        /// 
        /// <returns>The response from the ListHostedZonesByName service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidDomainNameException">
        /// This error indicates that the specified domain name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public ListHostedZonesByNameResponse ListHostedZonesByName(ListHostedZonesByNameRequest request)
        {
            var marshaller = new ListHostedZonesByNameRequestMarshaller();
            var unmarshaller = ListHostedZonesByNameResponseUnmarshaller.Instance;

            return Invoke<ListHostedZonesByNameRequest,ListHostedZonesByNameResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListHostedZonesByName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZonesByName operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListHostedZonesByNameResponse> ListHostedZonesByNameAsync(ListHostedZonesByNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListHostedZonesByNameRequestMarshaller();
            var unmarshaller = ListHostedZonesByNameResponseUnmarshaller.Instance;

            return InvokeAsync<ListHostedZonesByNameRequest,ListHostedZonesByNameResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListResourceRecordSets


        /// <summary>
        /// Imagine all the resource record sets in a zone listed out in front of you. Imagine
        /// them sorted lexicographically first by DNS name (with the labels reversed, like "com.amazon.www"
        /// for example), and secondarily, lexicographically by record type. This operation retrieves
        /// at most MaxItems resource record sets from this list, in order, starting at a position
        /// specified by the Name and Type arguments:
        /// 
        ///  <ul> <li>If both Name and Type are omitted, this means start the results at the first
        /// RRSET in the HostedZone.</li> <li>If Name is specified but Type is omitted, this means
        /// start the results at the first RRSET in the list whose name is greater than or equal
        /// to Name. </li> <li>If both Name and Type are specified, this means start the results
        /// at the first RRSET in the list whose name is greater than or equal to Name and whose
        /// type is greater than or equal to Type.</li> <li>It is an error to specify the Type
        /// but not the Name.</li> </ul> 
        /// <para>
        /// Use ListResourceRecordSets to retrieve a single known record set by specifying the
        /// record set's name and type, and setting MaxItems = 1
        /// </para>
        ///  
        /// <para>
        /// To retrieve all the records in a HostedZone, first pause any processes making calls
        /// to ChangeResourceRecordSets. Initially call ListResourceRecordSets without a Name
        /// and Type to get the first page of record sets. For subsequent calls, set Name and
        /// Type to the NextName and NextType values returned by the previous response. 
        /// </para>
        ///  
        /// <para>
        /// In the presence of concurrent ChangeResourceRecordSets calls, there is no consistency
        /// of results across calls to ListResourceRecordSets. The only way to get a consistent
        /// multi-page snapshot of all RRSETs in a zone is to stop making changes while pagination
        /// is in progress.
        /// </para>
        ///  
        /// <para>
        /// However, the results from ListResourceRecordSets are consistent within a page. If
        /// MakeChange calls are taking place concurrently, the result of each one will either
        /// be completely visible in your results or not at all. You will not see partial changes,
        /// or changes that do not ultimately succeed. (This follows from the fact that MakeChange
        /// is atomic) 
        /// </para>
        ///  
        /// <para>
        /// The results from ListResourceRecordSets are strongly consistent with ChangeResourceRecordSets.
        /// To be precise, if a single process makes a call to ChangeResourceRecordSets and receives
        /// a successful response, the effects of that change will be visible in a subsequent
        /// call to ListResourceRecordSets by that process.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceRecordSets service method.</param>
        /// 
        /// <returns>The response from the ListResourceRecordSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        public ListResourceRecordSetsResponse ListResourceRecordSets(ListResourceRecordSetsRequest request)
        {
            var marshaller = new ListResourceRecordSetsRequestMarshaller();
            var unmarshaller = ListResourceRecordSetsResponseUnmarshaller.Instance;

            return Invoke<ListResourceRecordSetsRequest,ListResourceRecordSetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceRecordSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceRecordSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListResourceRecordSetsResponse> ListResourceRecordSetsAsync(ListResourceRecordSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListResourceRecordSetsRequestMarshaller();
            var unmarshaller = ListResourceRecordSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceRecordSetsRequest,ListResourceRecordSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListReusableDelegationSets


        /// <summary>
        /// To retrieve a list of your reusable delegation sets, send a <code>GET</code> request
        /// to the <code>/<i>Route 53 API version</i>/delegationset</code> resource. The response
        /// to this request includes a <code>DelegationSets</code> element with zero, one, or
        /// multiple <code>DelegationSet</code> child elements. By default, the list of delegation
        /// sets is displayed on a single page. You can control the length of the page that is
        /// displayed by using the <code>MaxItems</code> parameter. You can use the <code>Marker</code>
        /// parameter to control the delegation set that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// 
        /// <returns>The response from the ListReusableDelegationSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public ListReusableDelegationSetsResponse ListReusableDelegationSets()
        {
            return ListReusableDelegationSets(new ListReusableDelegationSetsRequest());
        }


        /// <summary>
        /// To retrieve a list of your reusable delegation sets, send a <code>GET</code> request
        /// to the <code>/<i>Route 53 API version</i>/delegationset</code> resource. The response
        /// to this request includes a <code>DelegationSets</code> element with zero, one, or
        /// multiple <code>DelegationSet</code> child elements. By default, the list of delegation
        /// sets is displayed on a single page. You can control the length of the page that is
        /// displayed by using the <code>MaxItems</code> parameter. You can use the <code>Marker</code>
        /// parameter to control the delegation set that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReusableDelegationSets service method.</param>
        /// 
        /// <returns>The response from the ListReusableDelegationSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public ListReusableDelegationSetsResponse ListReusableDelegationSets(ListReusableDelegationSetsRequest request)
        {
            var marshaller = new ListReusableDelegationSetsRequestMarshaller();
            var unmarshaller = ListReusableDelegationSetsResponseUnmarshaller.Instance;

            return Invoke<ListReusableDelegationSetsRequest,ListReusableDelegationSetsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// To retrieve a list of your reusable delegation sets, send a <code>GET</code> request
        /// to the <code>/<i>Route 53 API version</i>/delegationset</code> resource. The response
        /// to this request includes a <code>DelegationSets</code> element with zero, one, or
        /// multiple <code>DelegationSet</code> child elements. By default, the list of delegation
        /// sets is displayed on a single page. You can control the length of the page that is
        /// displayed by using the <code>MaxItems</code> parameter. You can use the <code>Marker</code>
        /// parameter to control the delegation set that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReusableDelegationSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public Task<ListReusableDelegationSetsResponse> ListReusableDelegationSetsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListReusableDelegationSetsAsync(new ListReusableDelegationSetsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the ListReusableDelegationSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReusableDelegationSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListReusableDelegationSetsResponse> ListReusableDelegationSetsAsync(ListReusableDelegationSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListReusableDelegationSetsRequestMarshaller();
            var unmarshaller = ListReusableDelegationSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReusableDelegationSetsRequest,ListReusableDelegationSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Amazon Route 53 was still processing a prior request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.ThrottlingException">
        /// 
        /// </exception>
        public ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResources


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResources service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResources service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Amazon Route 53 was still processing a prior request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.ThrottlingException">
        /// 
        /// </exception>
        public ListTagsForResourcesResponse ListTagsForResources(ListTagsForResourcesRequest request)
        {
            var marshaller = new ListTagsForResourcesRequestMarshaller();
            var unmarshaller = ListTagsForResourcesResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourcesRequest,ListTagsForResourcesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListTagsForResourcesResponse> ListTagsForResourcesAsync(ListTagsForResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTagsForResourcesRequestMarshaller();
            var unmarshaller = ListTagsForResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourcesRequest,ListTagsForResourcesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTrafficPolicies


        /// <summary>
        /// Gets information about the latest version for every traffic policy that is associated
        /// with the current AWS account. To get the information, send a <code>GET</code> request
        /// to the <code>/<i>Route 53 API version</i>/trafficpolicy</code> resource.
        /// 
        ///  
        /// <para>
        /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
        /// of traffic policies, you can use the <code>maxitems</code> parameter to list them
        /// in groups of up to 100.
        /// </para>
        ///  
        /// <para>
        /// The response includes three values that help you navigate from one group of <code>maxitems</code>
        /// traffic policies to the next:
        /// </para>
        ///  <ul> <li><b>IsTruncated</b></li> 
        /// <para>
        /// If the value of <code>IsTruncated</code> in the response is <code>true</code>, there
        /// are more traffic policies associated with the current AWS account.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, this response includes the last
        /// traffic policy that is associated with the current account.
        /// </para>
        ///  <li><b>TrafficPolicyIdMarker</b></li> 
        /// <para>
        /// If <code>IsTruncated</code> is <code>true</code>, <code>TrafficPolicyIdMarker</code>
        /// is the ID of the first traffic policy in the next group of <code>MaxItems</code> traffic
        /// policies. If you want to list more traffic policies, make another call to <code>ListTrafficPolicies</code>,
        /// and specify the value of the <code>TrafficPolicyIdMarker</code> element from the response
        /// in the <code>TrafficPolicyIdMarker</code> request parameter.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, the <code>TrafficPolicyIdMarker</code>
        /// element is omitted from the response.
        /// </para>
        ///  <li><b>MaxItems</b></li> 
        /// <para>
        /// The value that you specified for the <code>MaxItems</code> parameter in the request
        /// that produced the current response.
        /// </para>
        ///  </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicies service method.</param>
        /// 
        /// <returns>The response from the ListTrafficPolicies service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public ListTrafficPoliciesResponse ListTrafficPolicies(ListTrafficPoliciesRequest request)
        {
            var marshaller = new ListTrafficPoliciesRequestMarshaller();
            var unmarshaller = ListTrafficPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPoliciesRequest,ListTrafficPoliciesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListTrafficPoliciesResponse> ListTrafficPoliciesAsync(ListTrafficPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTrafficPoliciesRequestMarshaller();
            var unmarshaller = ListTrafficPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPoliciesRequest,ListTrafficPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTrafficPolicyInstances


        /// <summary>
        /// Gets information about the traffic policy instances that you created by using the
        /// current AWS account.
        /// 
        ///  <note>After you submit an <code>UpdateTrafficPolicyInstance</code> request, there's
        /// a brief delay while Amazon Route 53 creates the resource record sets that are specified
        /// in the traffic policy definition. For more information, see the <a>State</a> response
        /// element.</note> 
        /// <para>
        /// To get information about the traffic policy instances that are associated with the
        /// current AWS account, send a <code>GET</code> request to the <code>/<i>Route 53 API
        /// version</i>/trafficpolicyinstance</code> resource.
        /// </para>
        ///  
        /// <para>
        /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
        /// of traffic policy instances, you can use the <code>MaxItems</code> parameter to list
        /// them in groups of up to 100.
        /// </para>
        ///  
        /// <para>
        /// The response includes five values that help you navigate from one group of <code>MaxItems</code>
        /// traffic policy instances to the next:
        /// </para>
        ///  <ul> <li><b>IsTruncated</b></li> 
        /// <para>
        /// If the value of <code>IsTruncated</code> in the response is <code>true</code>, there
        /// are more traffic policy instances associated with the current AWS account.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, this response includes the last
        /// traffic policy instance that is associated with the current account.
        /// </para>
        ///  <li><b>MaxItems</b></li> 
        /// <para>
        /// The value that you specified for the <code>MaxItems</code> parameter in the request
        /// that produced the current response.
        /// </para>
        ///  <li><b>HostedZoneIdMarker</b>, <b>TrafficPolicyInstanceNameMarker</b>, and <b>TrafficPolicyInstanceTypeMarker</b></li>
        /// 
        /// <para>
        /// If <code>IsTruncated</code> is <code>true</code>, these three values in the response
        /// represent the first traffic policy instance in the next group of <code>MaxItems</code>
        /// traffic policy instances. To list more traffic policy instances, make another call
        /// to <code>ListTrafficPolicyInstances</code>, and specify these values in the corresponding
        /// request parameters.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, all three elements are omitted
        /// from the response.
        /// </para>
        ///  </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstances service method.</param>
        /// 
        /// <returns>The response from the ListTrafficPolicyInstances service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyInstanceException">
        /// No traffic policy instance exists with the specified ID.
        /// </exception>
        public ListTrafficPolicyInstancesResponse ListTrafficPolicyInstances(ListTrafficPolicyInstancesRequest request)
        {
            var marshaller = new ListTrafficPolicyInstancesRequestMarshaller();
            var unmarshaller = ListTrafficPolicyInstancesResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPolicyInstancesRequest,ListTrafficPolicyInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicyInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListTrafficPolicyInstancesResponse> ListTrafficPolicyInstancesAsync(ListTrafficPolicyInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTrafficPolicyInstancesRequestMarshaller();
            var unmarshaller = ListTrafficPolicyInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPolicyInstancesRequest,ListTrafficPolicyInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTrafficPolicyInstancesByHostedZone


        /// <summary>
        /// Gets information about the traffic policy instances that you created in a specified
        /// hosted zone.
        /// 
        ///  <note>After you submit an <code>UpdateTrafficPolicyInstance</code> request, there's
        /// a brief delay while Amazon Route 53 creates the resource record sets that are specified
        /// in the traffic policy definition. For more information, see the <a>State</a> response
        /// element.</note> 
        /// <para>
        /// To get information about the traffic policy instances that you created in a specified
        /// hosted zone, send a <code>GET</code> request to the <code>/<i>Route 53 API version</i>/trafficpolicyinstance</code>
        /// resource and include the ID of the hosted zone.
        /// </para>
        ///  
        /// <para>
        /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
        /// of traffic policy instances, you can use the <code>MaxItems</code> parameter to list
        /// them in groups of up to 100.
        /// </para>
        ///  
        /// <para>
        /// The response includes four values that help you navigate from one group of <code>MaxItems</code>
        /// traffic policy instances to the next:
        /// </para>
        ///  <ul> <li><b>IsTruncated</b></li> 
        /// <para>
        /// If the value of <code/>IsTruncated in the response is <code>true</code>, there are
        /// more traffic policy instances associated with the current AWS account.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, this response includes the last
        /// traffic policy instance that is associated with the current account.
        /// </para>
        ///  <li><b>MaxItems</b></li> 
        /// <para>
        /// The value that you specified for the <code>MaxItems</code> parameter in the request
        /// that produced the current response.
        /// </para>
        ///  <li><b>TrafficPolicyInstanceNameMarker</b> and <b>TrafficPolicyInstanceTypeMarker</b></li>
        /// 
        /// <para>
        /// If <code>IsTruncated</code> is <code>true</code>, these two values in the response
        /// represent the first traffic policy instance in the next group of <code>MaxItems</code>
        /// traffic policy instances. To list more traffic policy instances, make another call
        /// to <code>ListTrafficPolicyInstancesByHostedZone</code>, and specify these values in
        /// the corresponding request parameters.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, all three elements are omitted
        /// from the response.
        /// </para>
        ///  </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstancesByHostedZone service method.</param>
        /// 
        /// <returns>The response from the ListTrafficPolicyInstancesByHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyInstanceException">
        /// No traffic policy instance exists with the specified ID.
        /// </exception>
        public ListTrafficPolicyInstancesByHostedZoneResponse ListTrafficPolicyInstancesByHostedZone(ListTrafficPolicyInstancesByHostedZoneRequest request)
        {
            var marshaller = new ListTrafficPolicyInstancesByHostedZoneRequestMarshaller();
            var unmarshaller = ListTrafficPolicyInstancesByHostedZoneResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPolicyInstancesByHostedZoneRequest,ListTrafficPolicyInstancesByHostedZoneResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicyInstancesByHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstancesByHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListTrafficPolicyInstancesByHostedZoneResponse> ListTrafficPolicyInstancesByHostedZoneAsync(ListTrafficPolicyInstancesByHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTrafficPolicyInstancesByHostedZoneRequestMarshaller();
            var unmarshaller = ListTrafficPolicyInstancesByHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPolicyInstancesByHostedZoneRequest,ListTrafficPolicyInstancesByHostedZoneResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTrafficPolicyInstancesByPolicy


        /// <summary>
        /// Gets information about the traffic policy instances that you created by using a specify
        /// traffic policy version.
        /// 
        ///  <note>After you submit a <code>CreateTrafficPolicyInstance</code> or an <code>UpdateTrafficPolicyInstance</code>
        /// request, there's a brief delay while Amazon Route 53 creates the resource record sets
        /// that are specified in the traffic policy definition. For more information, see the
        /// <a>State</a> response element.</note> 
        /// <para>
        /// To get information about the traffic policy instances that you created by using a
        /// specify traffic policy version, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/trafficpolicyinstance</code> resource and include the ID and version
        /// of the traffic policy.
        /// </para>
        ///  
        /// <para>
        /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
        /// of traffic policy instances, you can use the <code>MaxItems</code> parameter to list
        /// them in groups of up to 100.
        /// </para>
        ///  
        /// <para>
        /// The response includes five values that help you navigate from one group of <code>MaxItems</code>
        /// traffic policy instances to the next:
        /// </para>
        ///  <ul> <li><b>IsTruncated</b> 
        /// <para>
        /// If the value of <code>IsTruncated</code> in the response is <code>true</code>, there
        /// are more traffic policy instances associated with the specified traffic policy.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, this response includes the last
        /// traffic policy instance that is associated with the specified traffic policy.
        /// </para>
        ///  </li> <li><b>MaxItems</b> 
        /// <para>
        /// The value that you specified for the <code>MaxItems</code> parameter in the request
        /// that produced the current response.
        /// </para>
        ///  </li> <li><b>HostedZoneIdMarker</b>, <b>TrafficPolicyInstanceNameMarker</b>, and
        /// <b>TrafficPolicyInstanceTypeMarker</b> 
        /// <para>
        /// If <code>IsTruncated</code> is <code>true</code>, these values in the response represent
        /// the first traffic policy instance in the next group of <code>MaxItems</code> traffic
        /// policy instances. To list more traffic policy instances, make another call to <code>ListTrafficPolicyInstancesByPolicy</code>,
        /// and specify these values in the corresponding request parameters.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, all three elements are omitted
        /// from the response.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstancesByPolicy service method.</param>
        /// 
        /// <returns>The response from the ListTrafficPolicyInstancesByPolicy service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyInstanceException">
        /// No traffic policy instance exists with the specified ID.
        /// </exception>
        public ListTrafficPolicyInstancesByPolicyResponse ListTrafficPolicyInstancesByPolicy(ListTrafficPolicyInstancesByPolicyRequest request)
        {
            var marshaller = new ListTrafficPolicyInstancesByPolicyRequestMarshaller();
            var unmarshaller = ListTrafficPolicyInstancesByPolicyResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPolicyInstancesByPolicyRequest,ListTrafficPolicyInstancesByPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicyInstancesByPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstancesByPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListTrafficPolicyInstancesByPolicyResponse> ListTrafficPolicyInstancesByPolicyAsync(ListTrafficPolicyInstancesByPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTrafficPolicyInstancesByPolicyRequestMarshaller();
            var unmarshaller = ListTrafficPolicyInstancesByPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPolicyInstancesByPolicyRequest,ListTrafficPolicyInstancesByPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTrafficPolicyVersions


        /// <summary>
        /// Gets information about all of the versions for a specified traffic policy. <code>ListTrafficPolicyVersions</code>
        /// lists only versions that have not been deleted.
        /// 
        ///  
        /// <para>
        /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
        /// of traffic policies, you can use the <code>maxitems</code> parameter to list them
        /// in groups of up to 100.
        /// </para>
        ///  
        /// <para>
        /// The response includes three values that help you navigate from one group of <code>maxitems</code>maxitems
        /// traffic policies to the next:
        /// </para>
        ///  <ul> <li><b>IsTruncated</b></li> 
        /// <para>
        /// If the value of <code>IsTruncated</code> in the response is <code>true</code>, there
        /// are more traffic policy versions associated with the specified traffic policy.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, this response includes the last
        /// traffic policy version that is associated with the specified traffic policy.
        /// </para>
        ///  <li><b>TrafficPolicyVersionMarker</b></li> 
        /// <para>
        /// The ID of the next traffic policy version that is associated with the current AWS
        /// account. If you want to list more traffic policies, make another call to <code>ListTrafficPolicyVersions</code>,
        /// and specify the value of the <code>TrafficPolicyVersionMarker</code> element in the
        /// <code>TrafficPolicyVersionMarker</code> request parameter.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, Amazon Route 53 omits the <code>TrafficPolicyVersionMarker</code>
        /// element from the response.
        /// </para>
        ///  <li><b>MaxItems</b></li> 
        /// <para>
        /// The value that you specified for the <code>MaxItems</code> parameter in the request
        /// that produced the current response.
        /// </para>
        ///  </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyVersions service method.</param>
        /// 
        /// <returns>The response from the ListTrafficPolicyVersions service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        public ListTrafficPolicyVersionsResponse ListTrafficPolicyVersions(ListTrafficPolicyVersionsRequest request)
        {
            var marshaller = new ListTrafficPolicyVersionsRequestMarshaller();
            var unmarshaller = ListTrafficPolicyVersionsResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPolicyVersionsRequest,ListTrafficPolicyVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListTrafficPolicyVersionsResponse> ListTrafficPolicyVersionsAsync(ListTrafficPolicyVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTrafficPolicyVersionsRequestMarshaller();
            var unmarshaller = ListTrafficPolicyVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPolicyVersionsRequest,ListTrafficPolicyVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateHealthCheck


        /// <summary>
        /// This action updates an existing health check.
        /// 
        ///  
        /// <para>
        /// To update a health check, send a <code>POST</code> request to the <code>/<i>Route
        /// 53 API version</i>/healthcheck/<i>health check ID</i></code> resource. The request
        /// body must include a document with an <code>UpdateHealthCheckRequest</code> element.
        /// The response returns an <code>UpdateHealthCheckResponse</code> element, which contains
        /// metadata about the health check.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHealthCheck service method.</param>
        /// 
        /// <returns>The response from the UpdateHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HealthCheckVersionMismatchException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        public UpdateHealthCheckResponse UpdateHealthCheck(UpdateHealthCheckRequest request)
        {
            var marshaller = new UpdateHealthCheckRequestMarshaller();
            var unmarshaller = UpdateHealthCheckResponseUnmarshaller.Instance;

            return Invoke<UpdateHealthCheckRequest,UpdateHealthCheckResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateHealthCheckResponse> UpdateHealthCheckAsync(UpdateHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateHealthCheckRequestMarshaller();
            var unmarshaller = UpdateHealthCheckResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateHealthCheckRequest,UpdateHealthCheckResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateHostedZoneComment


        /// <summary>
        /// To update the hosted zone comment, send a <code>POST</code> request to the <code>/<i>Route
        /// 53 API version</i>/hostedzone/<i>hosted zone ID</i></code> resource. The request body
        /// must include a document with a <code>UpdateHostedZoneCommentRequest</code> element.
        /// The response to this request includes the modified <code>HostedZone</code> element.
        /// 
        ///  <note> The comment can have a maximum length of 256 characters.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostedZoneComment service method.</param>
        /// 
        /// <returns>The response from the UpdateHostedZoneComment service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        public UpdateHostedZoneCommentResponse UpdateHostedZoneComment(UpdateHostedZoneCommentRequest request)
        {
            var marshaller = new UpdateHostedZoneCommentRequestMarshaller();
            var unmarshaller = UpdateHostedZoneCommentResponseUnmarshaller.Instance;

            return Invoke<UpdateHostedZoneCommentRequest,UpdateHostedZoneCommentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHostedZoneComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostedZoneComment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateHostedZoneCommentResponse> UpdateHostedZoneCommentAsync(UpdateHostedZoneCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateHostedZoneCommentRequestMarshaller();
            var unmarshaller = UpdateHostedZoneCommentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateHostedZoneCommentRequest,UpdateHostedZoneCommentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateTrafficPolicyComment


        /// <summary>
        /// Updates the comment for a specified traffic policy version.
        /// 
        ///  
        /// <para>
        /// To update the comment, send a <code>POST</code> request to the <code>/<i>Route 53
        /// API version</i>/trafficpolicy/</code> resource.
        /// </para>
        ///  
        /// <para>
        /// The request body must include a document with an <code>UpdateTrafficPolicyCommentRequest</code>
        /// element.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicyComment service method.</param>
        /// 
        /// <returns>The response from the UpdateTrafficPolicyComment service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to update the object at the same time that you did.
        /// Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        public UpdateTrafficPolicyCommentResponse UpdateTrafficPolicyComment(UpdateTrafficPolicyCommentRequest request)
        {
            var marshaller = new UpdateTrafficPolicyCommentRequestMarshaller();
            var unmarshaller = UpdateTrafficPolicyCommentResponseUnmarshaller.Instance;

            return Invoke<UpdateTrafficPolicyCommentRequest,UpdateTrafficPolicyCommentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrafficPolicyComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicyComment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateTrafficPolicyCommentResponse> UpdateTrafficPolicyCommentAsync(UpdateTrafficPolicyCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateTrafficPolicyCommentRequestMarshaller();
            var unmarshaller = UpdateTrafficPolicyCommentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTrafficPolicyCommentRequest,UpdateTrafficPolicyCommentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateTrafficPolicyInstance


        /// <summary>
        /// Updates the resource record sets in a specified hosted zone that were created based
        /// on the settings in a specified traffic policy version.
        /// 
        ///  <important>The DNS type of the resource record sets that you're updating must match
        /// the DNS type in the JSON document that is associated with the traffic policy version
        /// that you're using to update the traffic policy instance.</important> 
        /// <para>
        /// When you update a traffic policy instance, Amazon Route 53 continues to respond to
        /// DNS queries for the root resource record set name (such as example.com) while it replaces
        /// one group of resource record sets with another. Amazon Route 53 performs the following
        /// operations:
        /// </para>
        ///  <ol> <li>Amazon Route 53 creates a new group of resource record sets based on the
        /// specified traffic policy. This is true regardless of how substantial the differences
        /// are between the existing resource record sets and the new resource record sets. </li>
        /// <li>When all of the new resource record sets have been created, Amazon Route 53 starts
        /// to respond to DNS queries for the root resource record set name (such as example.com)
        /// by using the new resource record sets.</li> <li>Amazon Route 53 deletes the old group
        /// of resource record sets that are associated with the root resource record set name.</li>
        /// </ol> 
        /// <para>
        /// To update a traffic policy instance, send a <code>POST</code> request to the <code>/<i>Route
        /// 53 API version</i>/trafficpolicyinstance/<i>traffic policy ID</i></code> resource.
        /// The request body must include a document with an <code>UpdateTrafficPolicyInstanceRequest</code>
        /// element.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicyInstance service method.</param>
        /// 
        /// <returns>The response from the UpdateTrafficPolicyInstance service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConflictingTypesException">
        /// You tried to update a traffic policy instance by using a traffic policy version that
        /// has a different DNS type than the current type for the instance. You specified the
        /// type in the JSON document in the <code>CreateTrafficPolicy</code> or <code>CreateTrafficPolicyVersion</code>request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyInstanceException">
        /// No traffic policy instance exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Amazon Route 53 was still processing a prior request.
        /// </exception>
        public UpdateTrafficPolicyInstanceResponse UpdateTrafficPolicyInstance(UpdateTrafficPolicyInstanceRequest request)
        {
            var marshaller = new UpdateTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = UpdateTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateTrafficPolicyInstanceRequest,UpdateTrafficPolicyInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicyInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateTrafficPolicyInstanceResponse> UpdateTrafficPolicyInstanceAsync(UpdateTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = UpdateTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTrafficPolicyInstanceRequest,UpdateTrafficPolicyInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}