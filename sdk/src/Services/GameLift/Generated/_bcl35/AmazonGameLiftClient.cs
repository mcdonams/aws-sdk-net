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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.GameLift.Model;
using Amazon.GameLift.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.GameLift
{
    /// <summary>
    /// Implementation for accessing GameLift
    ///
    /// Amazon GameLift Service 
    /// <para>
    /// Welcome to the <i>Amazon GameLift API Reference</i>. Amazon GameLift is a managed
    /// Amazon Web Services (AWS) service for developers who need a scalable, server-based
    /// solution for multiplayer games. Amazon GameLift provides setup and deployment of game
    /// servers, and handles infrastructure scaling and session management. For more information
    /// about the GameLift service, including a feature overview, getting started guide, and
    /// tutorial, see the accompanying <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/">Amazon
    /// GameLift Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// This reference describes the low-level service API for GameLift. You can call this
    /// API directly or use the <a href="https://aws.amazon.com/tools/">AWS SDK</a> for your
    /// preferred language. The AWS SDK includes a set of high-level GameLift actions multiplayer
    /// game sessions. Alternatively, you can use the <a href="https://aws.amazon.com/cli/">AWS
    /// command-line interface</a> (CLI) tool, which includes commands for GameLift. For administrative
    /// actions, you can use the Amazon GameLift console. 
    /// </para>
    ///  
    /// <para>
    /// <b>Setting Up Your Game Servers</b>
    /// </para>
    ///  
    /// <para>
    /// Use these administrative actions to configure GameLift to host your game servers.
    /// When configuring GameLift, you'll need to (1) configure a build for your game and
    /// provide build files, and (2) set up one or more fleets to host game sessions.
    /// </para>
    ///  <ul> <li> <b>Build actions:</b> <ul> <li><a>ListBuilds</a></li> <li><a>CreateBuild</a></li>
    /// <li><a>DescribeBuild</a></li> <li><a>UpdateBuild</a></li> <li><a>DeleteBuild</a></li>
    /// <li><a>RequestUploadCredentials</a></li> </ul> </li> <li> <b>Fleet actions:</b> <ul>
    /// <li><a>ListFleets</a></li> <li><a>CreateFleet</a></li> <li>Describe fleet actions:
    /// <ul> <li><a>DescribeFleetAttributes</a></li> <li><a>DescribeFleetCapacity</a></li>
    /// <li><a>DescribeFleetPortSettings</a></li> <li><a>DescribeFleetUtilization</a></li>
    /// <li><a>DescribeEC2InstanceLimits</a></li> <li><a>DescribeFleetEvents</a></li> </ul>
    /// </li> <li>Update fleet actions: <ul> <li><a>UpdateFleetAttributes</a></li> <li><a>UpdateFleetCapacity</a></li>
    /// <li><a>UpdateFleetPortSettings</a></li> </ul> </li> <li><a>DeleteFleet</a></li> </ul>
    /// </li> <li> <b>Alias actions:</b> <ul> <li><a>ListAliases</a></li> <li><a>CreateAlias</a></li>
    /// <li><a>DescribeAlias</a></li> <li><a>UpdateAlias</a></li> <li><a>DeleteAlias</a></li>
    /// <li><a>ResolveAlias</a></li> </ul> </li> </ul> 
    /// <para>
    /// <b>Managing Game and Player Sessions Through GameLift</b>
    /// </para>
    ///  
    /// <para>
    /// Call these actions from your game clients and/or services to create and manage multiplayer
    /// game sessions.
    /// </para>
    ///  <ul> <li> <b>Game sessions</b> <ul> <li><a>CreateGameSession</a></li> <li><a>DescribeGameSessions</a></li>
    /// <li><a>UpdateGameSession</a></li> </ul> </li> <li> <b>Player sessions</b> <ul> <li><a>CreatePlayerSession</a></li>
    /// <li><a>CreatePlayerSessions</a></li> <li><a>DescribePlayerSessions</a></li> </ul>
    /// </li> <li> <b>Other actions:</b> <ul> <li><a>GetGameSessionLogUrl</a></li> </ul> </li>
    /// </ul>
    /// </summary>
    public partial class AmazonGameLiftClient : AmazonServiceClient, IAmazonGameLift
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonGameLiftClient with the credentials loaded from the application's
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
        public AmazonGameLiftClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGameLiftConfig()) { }

        /// <summary>
        /// Constructs AmazonGameLiftClient with the credentials loaded from the application's
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
        public AmazonGameLiftClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGameLiftConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonGameLiftClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonGameLiftClient Configuration Object</param>
        public AmazonGameLiftClient(AmazonGameLiftConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonGameLiftClient(AWSCredentials credentials)
            : this(credentials, new AmazonGameLiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGameLiftClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonGameLiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Credentials and an
        /// AmazonGameLiftClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonGameLiftClient Configuration Object</param>
        public AmazonGameLiftClient(AWSCredentials credentials, AmazonGameLiftConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGameLiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGameLiftConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGameLiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonGameLiftClient Configuration Object</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonGameLiftConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGameLiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGameLiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGameLiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonGameLiftClient Configuration Object</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonGameLiftConfig clientConfig)
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

        
        #region  CreateAlias

        /// <summary>
        /// Creates an alias for a fleet. You can use an alias to anonymize your fleet by referencing
        /// an alias instead of a specific fleet when you create game sessions. Amazon GameLift
        /// supports two types of routing strategies for aliases: simple and terminal. Use a simple
        /// alias to point to an active fleet. Use a terminal alias to display a message to incoming
        /// traffic instead of routing players to an active fleet. This option is useful when
        /// a game server is no longer supported but you want to provide better messaging than
        /// a standard 404 error.
        /// 
        ///  
        /// <para>
        /// To create a fleet alias, specify an alias name, routing strategy, and optional description.
        /// If successful, a new alias record is returned, including an alias ID, which you can
        /// reference when creating a game session. To reassign the alias to another fleet ID,
        /// call <a>UpdateAlias</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Please resolve the conflict before retrying
        /// this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Please resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var marshaller = new CreateAliasRequestMarshaller();
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasRequest,CreateAliasResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAlias
        ///         operation.</returns>
        public IAsyncResult BeginCreateAlias(CreateAliasRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateAliasRequestMarshaller();
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return BeginInvoke<CreateAliasRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAlias.</param>
        /// 
        /// <returns>Returns a  CreateAliasResult from GameLift.</returns>
        public  CreateAliasResponse EndCreateAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBuild

        /// <summary>
        /// Initializes a new build record and generates information required to upload a game
        /// build to Amazon GameLift. Once the build record has been created and is in an INITIALIZED
        /// state, you can upload your game build.
        /// 
        ///  <important>
        /// <para>
        /// To create a build, use the CLI command <code>upload-build</code>, which creates a
        /// new build record and uploads the build files in one step. (See the <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/">Amazon
        /// GameLift Developer Guide</a> for more details on the CLI and the upload process.)
        /// Call the <code>CreateBuild</code> action only if you have your own Amazon Simple Storage
        /// Service (Amazon S3) client and need to manually upload your build files.
        /// </para>
        /// </important> 
        /// <para>
        /// To create a new build, optionally specify a build name and version. This metadata
        /// is stored with other properties in the build record and is displayed in the GameLift
        /// console (but not visible to players). If successful, this action returns the newly
        /// created build record along with an Amazon S3 storage location and AWS account credentials.
        /// Use the location and credentials to upload your game build.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBuild service method.</param>
        /// 
        /// <returns>The response from the CreateBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Please resolve the conflict before retrying
        /// this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public CreateBuildResponse CreateBuild(CreateBuildRequest request)
        {
            var marshaller = new CreateBuildRequestMarshaller();
            var unmarshaller = CreateBuildResponseUnmarshaller.Instance;

            return Invoke<CreateBuildRequest,CreateBuildResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBuild operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBuild
        ///         operation.</returns>
        public IAsyncResult BeginCreateBuild(CreateBuildRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateBuildRequestMarshaller();
            var unmarshaller = CreateBuildResponseUnmarshaller.Instance;

            return BeginInvoke<CreateBuildRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBuild operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBuild.</param>
        /// 
        /// <returns>Returns a  CreateBuildResult from GameLift.</returns>
        public  CreateBuildResponse EndCreateBuild(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBuildResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFleet

        /// <summary>
        /// Creates a new fleet to host game servers. A fleet consists of a set of Amazon Elastic
        /// Compute Cloud (Amazon EC2) instances of a certain type, which defines the CPU, memory,
        /// storage, and networking capacity of each host in the fleet. See <a href="https://aws.amazon.com/ec2/instance-types/">Amazon
        /// EC2 Instance Types</a> for more information. Each instance in the fleet hosts a game
        /// server created from the specified game build. Once a fleet is in an ACTIVE state,
        /// it can begin hosting game sessions.
        /// 
        ///  
        /// <para>
        /// To create a new fleet, provide a name and the EC2 instance type for the new fleet,
        /// and specify the build and server launch path. Builds must be in a READY state before
        /// they can be used to build fleets. When configuring the new fleet, you can optionally
        /// (1) provide a set of launch parameters to be passed to a game server when activated;
        /// (2) limit incoming traffic to a specified range of IP addresses and port numbers;
        /// and (3) configure Amazon GameLift to store game session logs by specifying the path
        /// to the logs stored in your game server files. If the call is successful, Amazon GameLift
        /// performs the following tasks:
        /// </para>
        ///  <ul> <li>Creates a fleet record and sets the state to NEW.</li> <li>Sets the fleet's
        /// capacity to 1 "desired" and 1 "active" EC2 instance count.</li> <li>Creates an EC2
        /// instance and begins the process of initializing the fleet and activating a game server
        /// on the instance.</li> <li>Begins writing events to the fleet event log, which can
        /// be accessed in the GameLift console.</li> </ul> 
        /// <para>
        /// Once a fleet is created, use the following actions to change certain fleet properties
        /// (server launch parameters and log paths cannot be changed):
        /// </para>
        ///  <ul> <li> <a>UpdateFleetAttributes</a> -- Update fleet metadata, including name and
        /// description.</li> <li> <a>UpdateFleetCapacity</a> -- Increase or decrease the number
        /// of instances you want the fleet to maintain.</li> <li> <a>UpdateFleetPortSettings</a>
        /// -- Change the IP addresses and ports that allow access to incoming traffic.</li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Please resolve the conflict before retrying
        /// this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Please resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public CreateFleetResponse CreateFleet(CreateFleetRequest request)
        {
            var marshaller = new CreateFleetRequestMarshaller();
            var unmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return Invoke<CreateFleetRequest,CreateFleetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFleet
        ///         operation.</returns>
        public IAsyncResult BeginCreateFleet(CreateFleetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateFleetRequestMarshaller();
            var unmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return BeginInvoke<CreateFleetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFleet.</param>
        /// 
        /// <returns>Returns a  CreateFleetResult from GameLift.</returns>
        public  CreateFleetResponse EndCreateFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGameSession

        /// <summary>
        /// Creates a multiplayer game session for players. This action creates a game session
        /// record and assigns the new session to an instance in the specified fleet, which activates
        /// the server initialization process in your game server. A fleet must be in an ACTIVE
        /// state before a game session can be created for it.
        /// 
        ///  
        /// <para>
        /// To create a game session, specify either a fleet ID or an alias ID and indicate the
        /// maximum number of players the game session allows. You can also provide a name and
        /// a set of properties for your game (optional). If successful, a <a>GameSession</a>
        /// object is returned containing session properties, including an IP address. By default,
        /// newly created game sessions are set to accept adding any new players to the game session.
        /// Use <a>UpdateGameSession</a> to change the creation policy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGameSession service method.</param>
        /// 
        /// <returns>The response from the CreateGameSession service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Please resolve the conflict before retrying
        /// this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.FleetCapacityExceededException">
        /// The specified fleet has no available instances to fulfill a request to create a new
        /// game session. Such requests should only be retried once the fleet capacity has been
        /// increased.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Please resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public CreateGameSessionResponse CreateGameSession(CreateGameSessionRequest request)
        {
            var marshaller = new CreateGameSessionRequestMarshaller();
            var unmarshaller = CreateGameSessionResponseUnmarshaller.Instance;

            return Invoke<CreateGameSessionRequest,CreateGameSessionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGameSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGameSession operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGameSession
        ///         operation.</returns>
        public IAsyncResult BeginCreateGameSession(CreateGameSessionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateGameSessionRequestMarshaller();
            var unmarshaller = CreateGameSessionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateGameSessionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGameSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGameSession.</param>
        /// 
        /// <returns>Returns a  CreateGameSessionResult from GameLift.</returns>
        public  CreateGameSessionResponse EndCreateGameSession(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGameSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePlayerSession

        /// <summary>
        /// Adds a player to a game session and creates a player session record. A game session
        /// must be in an ACTIVE state, have a creation policy of ALLOW_ALL, and have an open
        /// player slot before players can be added to the session.
        /// 
        ///  
        /// <para>
        /// To create a player session, specify a game session ID and player ID. If successful,
        /// the player is added to the game session and a new <a>PlayerSession</a> object is returned.
        /// 
        /// </para>
        /// </summary>
        /// <param name="gameSessionId">Unique identifier for a game session. Specify the game session you want to add a player to.</param>
        /// <param name="playerId">Unique identifier for the player to be added.</param>
        /// 
        /// <returns>The response from the CreatePlayerSession service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.GameSessionFullException">
        /// The game instance is currently full and cannot allow the requested player(s) to join.
        /// This exception occurs in response to a <a>CreatePlayerSession</a> request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Such requests should not be
        /// retried by clients without resolving the conflict.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public CreatePlayerSessionResponse CreatePlayerSession(string gameSessionId, string playerId)
        {
            var request = new CreatePlayerSessionRequest();
            request.GameSessionId = gameSessionId;
            request.PlayerId = playerId;
            return CreatePlayerSession(request);
        }


        /// <summary>
        /// Adds a player to a game session and creates a player session record. A game session
        /// must be in an ACTIVE state, have a creation policy of ALLOW_ALL, and have an open
        /// player slot before players can be added to the session.
        /// 
        ///  
        /// <para>
        /// To create a player session, specify a game session ID and player ID. If successful,
        /// the player is added to the game session and a new <a>PlayerSession</a> object is returned.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlayerSession service method.</param>
        /// 
        /// <returns>The response from the CreatePlayerSession service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.GameSessionFullException">
        /// The game instance is currently full and cannot allow the requested player(s) to join.
        /// This exception occurs in response to a <a>CreatePlayerSession</a> request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Such requests should not be
        /// retried by clients without resolving the conflict.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public CreatePlayerSessionResponse CreatePlayerSession(CreatePlayerSessionRequest request)
        {
            var marshaller = new CreatePlayerSessionRequestMarshaller();
            var unmarshaller = CreatePlayerSessionResponseUnmarshaller.Instance;

            return Invoke<CreatePlayerSessionRequest,CreatePlayerSessionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlayerSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlayerSession operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePlayerSession
        ///         operation.</returns>
        public IAsyncResult BeginCreatePlayerSession(CreatePlayerSessionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreatePlayerSessionRequestMarshaller();
            var unmarshaller = CreatePlayerSessionResponseUnmarshaller.Instance;

            return BeginInvoke<CreatePlayerSessionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlayerSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlayerSession.</param>
        /// 
        /// <returns>Returns a  CreatePlayerSessionResult from GameLift.</returns>
        public  CreatePlayerSessionResponse EndCreatePlayerSession(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePlayerSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePlayerSessions

        /// <summary>
        /// Adds a group of players to a game session. Similar to <a>CreatePlayerSession</a>,
        /// this action allows you to add multiple players in a single call, which is useful for
        /// games that provide party and/or matchmaking features. A game session must be in an
        /// ACTIVE state, have a creation policy of ALLOW_ALL, and have an open player slot before
        /// players can be added to the session.
        /// 
        ///  
        /// <para>
        /// To create player sessions, specify a game session ID and a list of player IDs. If
        /// successful, the players are added to the game session and a set of new <a>PlayerSession</a>
        /// objects is returned. 
        /// </para>
        /// </summary>
        /// <param name="gameSessionId">Unique identifier for a game session. </param>
        /// <param name="playerIds">List of unique identifiers for the players to be added.</param>
        /// 
        /// <returns>The response from the CreatePlayerSessions service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.GameSessionFullException">
        /// The game instance is currently full and cannot allow the requested player(s) to join.
        /// This exception occurs in response to a <a>CreatePlayerSession</a> request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Such requests should not be
        /// retried by clients without resolving the conflict.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public CreatePlayerSessionsResponse CreatePlayerSessions(string gameSessionId, List<string> playerIds)
        {
            var request = new CreatePlayerSessionsRequest();
            request.GameSessionId = gameSessionId;
            request.PlayerIds = playerIds;
            return CreatePlayerSessions(request);
        }


        /// <summary>
        /// Adds a group of players to a game session. Similar to <a>CreatePlayerSession</a>,
        /// this action allows you to add multiple players in a single call, which is useful for
        /// games that provide party and/or matchmaking features. A game session must be in an
        /// ACTIVE state, have a creation policy of ALLOW_ALL, and have an open player slot before
        /// players can be added to the session.
        /// 
        ///  
        /// <para>
        /// To create player sessions, specify a game session ID and a list of player IDs. If
        /// successful, the players are added to the game session and a set of new <a>PlayerSession</a>
        /// objects is returned. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlayerSessions service method.</param>
        /// 
        /// <returns>The response from the CreatePlayerSessions service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.GameSessionFullException">
        /// The game instance is currently full and cannot allow the requested player(s) to join.
        /// This exception occurs in response to a <a>CreatePlayerSession</a> request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Such requests should not be
        /// retried by clients without resolving the conflict.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public CreatePlayerSessionsResponse CreatePlayerSessions(CreatePlayerSessionsRequest request)
        {
            var marshaller = new CreatePlayerSessionsRequestMarshaller();
            var unmarshaller = CreatePlayerSessionsResponseUnmarshaller.Instance;

            return Invoke<CreatePlayerSessionsRequest,CreatePlayerSessionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlayerSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlayerSessions operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePlayerSessions
        ///         operation.</returns>
        public IAsyncResult BeginCreatePlayerSessions(CreatePlayerSessionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreatePlayerSessionsRequestMarshaller();
            var unmarshaller = CreatePlayerSessionsResponseUnmarshaller.Instance;

            return BeginInvoke<CreatePlayerSessionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlayerSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlayerSessions.</param>
        /// 
        /// <returns>Returns a  CreatePlayerSessionsResult from GameLift.</returns>
        public  CreatePlayerSessionsResponse EndCreatePlayerSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePlayerSessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAlias

        /// <summary>
        /// Deletes an alias. This action removes all record of the alias; game clients attempting
        /// to access a game server using the deleted alias receive an error. To delete an alias,
        /// specify the alias ID to be deleted.
        /// </summary>
        /// <param name="aliasId">Unique identifier for a fleet alias. Specify the alias you want to delete. </param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public DeleteAliasResponse DeleteAlias(string aliasId)
        {
            var request = new DeleteAliasRequest();
            request.AliasId = aliasId;
            return DeleteAlias(request);
        }


        /// <summary>
        /// Deletes an alias. This action removes all record of the alias; game clients attempting
        /// to access a game server using the deleted alias receive an error. To delete an alias,
        /// specify the alias ID to be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
        {
            var marshaller = new DeleteAliasRequestMarshaller();
            var unmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAliasRequest,DeleteAliasResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAlias
        ///         operation.</returns>
        public IAsyncResult BeginDeleteAlias(DeleteAliasRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteAliasRequestMarshaller();
            var unmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteAliasRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlias.</param>
        /// 
        /// <returns>Returns a  DeleteAliasResult from GameLift.</returns>
        public  DeleteAliasResponse EndDeleteAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBuild

        /// <summary>
        /// Deletes a build. This action permanently deletes the build record and any uploaded
        /// build files.
        /// 
        ///  
        /// <para>
        /// To delete a build, specify its ID. Deleting a build does not affect the status of
        /// any active fleets, but you can no longer create new fleets for the deleted build.
        /// </para>
        /// </summary>
        /// <param name="buildId">Unique identifier for the build you want to delete. </param>
        /// 
        /// <returns>The response from the DeleteBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public DeleteBuildResponse DeleteBuild(string buildId)
        {
            var request = new DeleteBuildRequest();
            request.BuildId = buildId;
            return DeleteBuild(request);
        }


        /// <summary>
        /// Deletes a build. This action permanently deletes the build record and any uploaded
        /// build files.
        /// 
        ///  
        /// <para>
        /// To delete a build, specify its ID. Deleting a build does not affect the status of
        /// any active fleets, but you can no longer create new fleets for the deleted build.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBuild service method.</param>
        /// 
        /// <returns>The response from the DeleteBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public DeleteBuildResponse DeleteBuild(DeleteBuildRequest request)
        {
            var marshaller = new DeleteBuildRequestMarshaller();
            var unmarshaller = DeleteBuildResponseUnmarshaller.Instance;

            return Invoke<DeleteBuildRequest,DeleteBuildResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBuild operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBuild
        ///         operation.</returns>
        public IAsyncResult BeginDeleteBuild(DeleteBuildRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteBuildRequestMarshaller();
            var unmarshaller = DeleteBuildResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteBuildRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBuild operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBuild.</param>
        /// 
        /// <returns>Returns a  DeleteBuildResult from GameLift.</returns>
        public  DeleteBuildResponse EndDeleteBuild(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBuildResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFleet

        /// <summary>
        /// Deletes everything related to a fleet. Before deleting a fleet, you must set the fleet's
        /// desired capacity to zero. See <a>UpdateFleetCapacity</a>.
        /// 
        ///  
        /// <para>
        /// This action removes the fleet's resources and the fleet record. Once a fleet is deleted,
        /// you can no longer use that fleet.
        /// </para>
        /// </summary>
        /// <param name="fleetId">Unique identifier for the fleet you want to delete.</param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Please resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Please resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public DeleteFleetResponse DeleteFleet(string fleetId)
        {
            var request = new DeleteFleetRequest();
            request.FleetId = fleetId;
            return DeleteFleet(request);
        }


        /// <summary>
        /// Deletes everything related to a fleet. Before deleting a fleet, you must set the fleet's
        /// desired capacity to zero. See <a>UpdateFleetCapacity</a>.
        /// 
        ///  
        /// <para>
        /// This action removes the fleet's resources and the fleet record. Once a fleet is deleted,
        /// you can no longer use that fleet.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Please resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Please resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public DeleteFleetResponse DeleteFleet(DeleteFleetRequest request)
        {
            var marshaller = new DeleteFleetRequestMarshaller();
            var unmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetRequest,DeleteFleetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFleet
        ///         operation.</returns>
        public IAsyncResult BeginDeleteFleet(DeleteFleetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteFleetRequestMarshaller();
            var unmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteFleetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFleet.</param>
        /// 
        /// <returns>Returns a  DeleteFleetResult from GameLift.</returns>
        public  DeleteFleetResponse EndDeleteFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAlias

        /// <summary>
        /// Retrieves properties for a specified alias. To get the alias, specify an alias ID.
        /// If successful, an <a>Alias</a> object is returned.
        /// </summary>
        /// <param name="aliasId">Unique identifier for a fleet alias. Specify the alias you want to retrieve. </param>
        /// 
        /// <returns>The response from the DescribeAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public DescribeAliasResponse DescribeAlias(string aliasId)
        {
            var request = new DescribeAliasRequest();
            request.AliasId = aliasId;
            return DescribeAlias(request);
        }


        /// <summary>
        /// Retrieves properties for a specified alias. To get the alias, specify an alias ID.
        /// If successful, an <a>Alias</a> object is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlias service method.</param>
        /// 
        /// <returns>The response from the DescribeAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public DescribeAliasResponse DescribeAlias(DescribeAliasRequest request)
        {
            var marshaller = new DescribeAliasRequestMarshaller();
            var unmarshaller = DescribeAliasResponseUnmarshaller.Instance;

            return Invoke<DescribeAliasRequest,DescribeAliasResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlias operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlias
        ///         operation.</returns>
        public IAsyncResult BeginDescribeAlias(DescribeAliasRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeAliasRequestMarshaller();
            var unmarshaller = DescribeAliasResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAliasRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlias.</param>
        /// 
        /// <returns>Returns a  DescribeAliasResult from GameLift.</returns>
        public  DescribeAliasResponse EndDescribeAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBuild

        /// <summary>
        /// Retrieves properties for a build. To get a build record, specify a build ID. If successful,
        /// an object containing the build properties is returned.
        /// </summary>
        /// <param name="buildId">Unique identifier for the build you want to retrieve properties for. </param>
        /// 
        /// <returns>The response from the DescribeBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public DescribeBuildResponse DescribeBuild(string buildId)
        {
            var request = new DescribeBuildRequest();
            request.BuildId = buildId;
            return DescribeBuild(request);
        }


        /// <summary>
        /// Retrieves properties for a build. To get a build record, specify a build ID. If successful,
        /// an object containing the build properties is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBuild service method.</param>
        /// 
        /// <returns>The response from the DescribeBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public DescribeBuildResponse DescribeBuild(DescribeBuildRequest request)
        {
            var marshaller = new DescribeBuildRequestMarshaller();
            var unmarshaller = DescribeBuildResponseUnmarshaller.Instance;

            return Invoke<DescribeBuildRequest,DescribeBuildResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBuild operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBuild
        ///         operation.</returns>
        public IAsyncResult BeginDescribeBuild(DescribeBuildRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeBuildRequestMarshaller();
            var unmarshaller = DescribeBuildResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeBuildRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBuild operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBuild.</param>
        /// 
        /// <returns>Returns a  DescribeBuildResult from GameLift.</returns>
        public  DescribeBuildResponse EndDescribeBuild(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBuildResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEC2InstanceLimits

        /// <summary>
        /// Retrieves the maximum number of instances allowed, per AWS account, for each specified
        /// EC2 instance type. The current usage level for the AWS account is also retrieved.
        /// </summary>
        /// <param name="ec2InstanceType">Type of EC2 instances used in the fleet. EC2 instance types define the CPU, memory, storage, and networking capacity of the fleetaposs hosts. Amazon GameLift supports the EC2 instance types listed below. See <a href="https://aws.amazon.com/ec2/instance-types/">Amazon EC2 Instance Types</a> for detailed descriptions of each. Leave this parameter blank to retrieve limits for all types.</param>
        /// 
        /// <returns>The response from the DescribeEC2InstanceLimits service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public DescribeEC2InstanceLimitsResponse DescribeEC2InstanceLimits(EC2InstanceType ec2InstanceType)
        {
            var request = new DescribeEC2InstanceLimitsRequest();
            request.EC2InstanceType = ec2InstanceType;
            return DescribeEC2InstanceLimits(request);
        }


        /// <summary>
        /// Retrieves the maximum number of instances allowed, per AWS account, for each specified
        /// EC2 instance type. The current usage level for the AWS account is also retrieved.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEC2InstanceLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeEC2InstanceLimits service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public DescribeEC2InstanceLimitsResponse DescribeEC2InstanceLimits(DescribeEC2InstanceLimitsRequest request)
        {
            var marshaller = new DescribeEC2InstanceLimitsRequestMarshaller();
            var unmarshaller = DescribeEC2InstanceLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeEC2InstanceLimitsRequest,DescribeEC2InstanceLimitsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEC2InstanceLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEC2InstanceLimits operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEC2InstanceLimits
        ///         operation.</returns>
        public IAsyncResult BeginDescribeEC2InstanceLimits(DescribeEC2InstanceLimitsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeEC2InstanceLimitsRequestMarshaller();
            var unmarshaller = DescribeEC2InstanceLimitsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeEC2InstanceLimitsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEC2InstanceLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEC2InstanceLimits.</param>
        /// 
        /// <returns>Returns a  DescribeEC2InstanceLimitsResult from GameLift.</returns>
        public  DescribeEC2InstanceLimitsResponse EndDescribeEC2InstanceLimits(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEC2InstanceLimitsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFleetAttributes

        /// <summary>
        /// Retrieves fleet properties, including metadata, status, and configuration, for one
        /// or more fleets. You can request attributes for all fleets, or specify a list of one
        /// or more fleet IDs. When requesting all fleets, use the pagination parameters to retrieve
        /// results as a set of sequential pages. If successful, a <a>FleetAttributes</a> object
        /// is returned for each requested fleet ID. When specifying a list of fleet IDs, attribute
        /// objects are returned only for fleets that currently exist. 
        /// 
        ///  <note>
        /// <para>
        /// Some API actions may limit the number of fleet IDs allowed in one request. If a request
        /// exceeds this limit, the request fails and the error message includes the maximum allowed.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetAttributes service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public DescribeFleetAttributesResponse DescribeFleetAttributes(DescribeFleetAttributesRequest request)
        {
            var marshaller = new DescribeFleetAttributesRequestMarshaller();
            var unmarshaller = DescribeFleetAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetAttributesRequest,DescribeFleetAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAttributes operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetAttributes
        ///         operation.</returns>
        public IAsyncResult BeginDescribeFleetAttributes(DescribeFleetAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeFleetAttributesRequestMarshaller();
            var unmarshaller = DescribeFleetAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeFleetAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeFleetAttributesResult from GameLift.</returns>
        public  DescribeFleetAttributesResponse EndDescribeFleetAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFleetAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFleetCapacity

        /// <summary>
        /// Retrieves the current status of fleet capacity for one or more fleets. This information
        /// includes the number of instances that have been requested for the fleet and the number
        /// currently active. You can request capacity for all fleets, or specify a list of one
        /// or more fleet IDs. When requesting all fleets, use the pagination parameters to retrieve
        /// results as a set of sequential pages. If successful, a <a>FleetCapacity</a> object
        /// is returned for each requested fleet ID. When specifying a list of fleet IDs, attribute
        /// objects are returned only for fleets that currently exist. 
        /// 
        ///  <note>
        /// <para>
        /// Some API actions may limit the number of fleet IDs allowed in one request. If a request
        /// exceeds this limit, the request fails and the error message includes the maximum allowed.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetCapacity service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetCapacity service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public DescribeFleetCapacityResponse DescribeFleetCapacity(DescribeFleetCapacityRequest request)
        {
            var marshaller = new DescribeFleetCapacityRequestMarshaller();
            var unmarshaller = DescribeFleetCapacityResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetCapacityRequest,DescribeFleetCapacityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetCapacity operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetCapacity
        ///         operation.</returns>
        public IAsyncResult BeginDescribeFleetCapacity(DescribeFleetCapacityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeFleetCapacityRequestMarshaller();
            var unmarshaller = DescribeFleetCapacityResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeFleetCapacityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetCapacity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetCapacity.</param>
        /// 
        /// <returns>Returns a  DescribeFleetCapacityResult from GameLift.</returns>
        public  DescribeFleetCapacityResponse EndDescribeFleetCapacity(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFleetCapacityResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFleetEvents

        /// <summary>
        /// Retrieves entries from the fleet event log. You can specify a time range to limit
        /// the result set. Use the pagination parameters to retrieve results as a set of sequential
        /// pages. If successful, a collection of event log entries matching the request are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetEvents service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public DescribeFleetEventsResponse DescribeFleetEvents(DescribeFleetEventsRequest request)
        {
            var marshaller = new DescribeFleetEventsRequestMarshaller();
            var unmarshaller = DescribeFleetEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetEventsRequest,DescribeFleetEventsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetEvents operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetEvents
        ///         operation.</returns>
        public IAsyncResult BeginDescribeFleetEvents(DescribeFleetEventsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeFleetEventsRequestMarshaller();
            var unmarshaller = DescribeFleetEventsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeFleetEventsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetEvents.</param>
        /// 
        /// <returns>Returns a  DescribeFleetEventsResult from GameLift.</returns>
        public  DescribeFleetEventsResponse EndDescribeFleetEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFleetEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFleetPortSettings

        /// <summary>
        /// Retrieves the port settings for a fleet. Port settings are used to limit incoming
        /// traffic access to game servers in the fleet. To get a fleet's port settings, specify
        /// a fleet ID. If successful, an <a>IpPermission</a> object is returned for the requested
        /// fleet ID. If the requested fleet has been deleted, the result set will be empty.
        /// </summary>
        /// <param name="fleetId">Unique identifier for the fleet you want to retrieve port settings for. </param>
        /// 
        /// <returns>The response from the DescribeFleetPortSettings service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public DescribeFleetPortSettingsResponse DescribeFleetPortSettings(string fleetId)
        {
            var request = new DescribeFleetPortSettingsRequest();
            request.FleetId = fleetId;
            return DescribeFleetPortSettings(request);
        }


        /// <summary>
        /// Retrieves the port settings for a fleet. Port settings are used to limit incoming
        /// traffic access to game servers in the fleet. To get a fleet's port settings, specify
        /// a fleet ID. If successful, an <a>IpPermission</a> object is returned for the requested
        /// fleet ID. If the requested fleet has been deleted, the result set will be empty.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetPortSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetPortSettings service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public DescribeFleetPortSettingsResponse DescribeFleetPortSettings(DescribeFleetPortSettingsRequest request)
        {
            var marshaller = new DescribeFleetPortSettingsRequestMarshaller();
            var unmarshaller = DescribeFleetPortSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetPortSettingsRequest,DescribeFleetPortSettingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetPortSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetPortSettings operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetPortSettings
        ///         operation.</returns>
        public IAsyncResult BeginDescribeFleetPortSettings(DescribeFleetPortSettingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeFleetPortSettingsRequestMarshaller();
            var unmarshaller = DescribeFleetPortSettingsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeFleetPortSettingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetPortSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetPortSettings.</param>
        /// 
        /// <returns>Returns a  DescribeFleetPortSettingsResult from GameLift.</returns>
        public  DescribeFleetPortSettingsResponse EndDescribeFleetPortSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFleetPortSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFleetUtilization

        /// <summary>
        /// Retrieves utilization statistics for one or more fleets. You can request utilization
        /// data for all fleets, or specify a list of one or more fleet IDs. When requesting all
        /// fleets, use the pagination parameters to retrieve results as a set of sequential pages.
        /// If successful, a <a>FleetUtilization</a> object is returned for each requested fleet
        /// ID. When specifying a list of fleet IDs, utilization objects are returned only for
        /// fleets that currently exist. 
        /// 
        ///  <note>
        /// <para>
        /// Some API actions may limit the number of fleet IDs allowed in one request. If a request
        /// exceeds this limit, the request fails and the error message includes the maximum allowed.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetUtilization service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetUtilization service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public DescribeFleetUtilizationResponse DescribeFleetUtilization(DescribeFleetUtilizationRequest request)
        {
            var marshaller = new DescribeFleetUtilizationRequestMarshaller();
            var unmarshaller = DescribeFleetUtilizationResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetUtilizationRequest,DescribeFleetUtilizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetUtilization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetUtilization operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetUtilization
        ///         operation.</returns>
        public IAsyncResult BeginDescribeFleetUtilization(DescribeFleetUtilizationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeFleetUtilizationRequestMarshaller();
            var unmarshaller = DescribeFleetUtilizationResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeFleetUtilizationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetUtilization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetUtilization.</param>
        /// 
        /// <returns>Returns a  DescribeFleetUtilizationResult from GameLift.</returns>
        public  DescribeFleetUtilizationResponse EndDescribeFleetUtilization(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFleetUtilizationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGameSessions

        /// <summary>
        /// Retrieves properties for one or more game sessions. This action can be used in several
        /// ways: (1) provide a <i>GameSessionId</i> parameter to request properties for a specific
        /// game session; (2) provide a <i>FleetId</i> or <i>AliasId</i> parameter to request
        /// properties for all game sessions running on a fleet. 
        /// 
        ///  
        /// <para>
        /// To get game session record(s), specify only one of the following: game session ID,
        /// fleet ID, or alias ID. You can filter this request by game session status. Use the
        /// pagination parameters to retrieve results as a set of sequential pages. If successful,
        /// a <a>GameSession</a> object is returned for each session matching the request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessions service method.</param>
        /// 
        /// <returns>The response from the DescribeGameSessions service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public DescribeGameSessionsResponse DescribeGameSessions(DescribeGameSessionsRequest request)
        {
            var marshaller = new DescribeGameSessionsRequestMarshaller();
            var unmarshaller = DescribeGameSessionsResponseUnmarshaller.Instance;

            return Invoke<DescribeGameSessionsRequest,DescribeGameSessionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGameSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessions operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGameSessions
        ///         operation.</returns>
        public IAsyncResult BeginDescribeGameSessions(DescribeGameSessionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeGameSessionsRequestMarshaller();
            var unmarshaller = DescribeGameSessionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeGameSessionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGameSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGameSessions.</param>
        /// 
        /// <returns>Returns a  DescribeGameSessionsResult from GameLift.</returns>
        public  DescribeGameSessionsResponse EndDescribeGameSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGameSessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePlayerSessions

        /// <summary>
        /// Retrieves properties for one or more player sessions. This action can be used in several
        /// ways: (1) provide a <i>PlayerSessionId</i> parameter to request properties for a specific
        /// player session; (2) provide a <i>GameSessionId</i> parameter to request properties
        /// for all player sessions in the specified game session; (3) provide a <i>PlayerId</i>
        /// parameter to request properties for all player sessions of a specified player. 
        /// 
        ///  
        /// <para>
        /// To get game session record(s), specify only one of the following: a player session
        /// ID, a game session ID, or a player ID. You can filter this request by player session
        /// status. Use the pagination parameters to retrieve results as a set of sequential pages.
        /// If successful, a <a>PlayerSession</a> object is returned for each session matching
        /// the request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePlayerSessions service method.</param>
        /// 
        /// <returns>The response from the DescribePlayerSessions service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public DescribePlayerSessionsResponse DescribePlayerSessions(DescribePlayerSessionsRequest request)
        {
            var marshaller = new DescribePlayerSessionsRequestMarshaller();
            var unmarshaller = DescribePlayerSessionsResponseUnmarshaller.Instance;

            return Invoke<DescribePlayerSessionsRequest,DescribePlayerSessionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePlayerSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlayerSessions operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePlayerSessions
        ///         operation.</returns>
        public IAsyncResult BeginDescribePlayerSessions(DescribePlayerSessionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribePlayerSessionsRequestMarshaller();
            var unmarshaller = DescribePlayerSessionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribePlayerSessionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePlayerSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePlayerSessions.</param>
        /// 
        /// <returns>Returns a  DescribePlayerSessionsResult from GameLift.</returns>
        public  DescribePlayerSessionsResponse EndDescribePlayerSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePlayerSessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGameSessionLogUrl

        /// <summary>
        /// Retrieves the location of stored game session logs for a specified game session. When
        /// a game session is terminated, Amazon GameLift automatically stores the logs in Amazon
        /// S3. Use this URL to download the logs.
        /// 
        ///  <note>
        /// <para>
        /// See the <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_gamelift">AWS
        /// Service Limits</a> page for maximum log file sizes. Log files that exceed this limit
        /// are not saved.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="gameSessionId">Unique identifier for a game session. Specify the game session you want to get logs for.</param>
        /// 
        /// <returns>The response from the GetGameSessionLogUrl service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public GetGameSessionLogUrlResponse GetGameSessionLogUrl(string gameSessionId)
        {
            var request = new GetGameSessionLogUrlRequest();
            request.GameSessionId = gameSessionId;
            return GetGameSessionLogUrl(request);
        }


        /// <summary>
        /// Retrieves the location of stored game session logs for a specified game session. When
        /// a game session is terminated, Amazon GameLift automatically stores the logs in Amazon
        /// S3. Use this URL to download the logs.
        /// 
        ///  <note>
        /// <para>
        /// See the <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_gamelift">AWS
        /// Service Limits</a> page for maximum log file sizes. Log files that exceed this limit
        /// are not saved.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGameSessionLogUrl service method.</param>
        /// 
        /// <returns>The response from the GetGameSessionLogUrl service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public GetGameSessionLogUrlResponse GetGameSessionLogUrl(GetGameSessionLogUrlRequest request)
        {
            var marshaller = new GetGameSessionLogUrlRequestMarshaller();
            var unmarshaller = GetGameSessionLogUrlResponseUnmarshaller.Instance;

            return Invoke<GetGameSessionLogUrlRequest,GetGameSessionLogUrlResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGameSessionLogUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGameSessionLogUrl operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGameSessionLogUrl
        ///         operation.</returns>
        public IAsyncResult BeginGetGameSessionLogUrl(GetGameSessionLogUrlRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetGameSessionLogUrlRequestMarshaller();
            var unmarshaller = GetGameSessionLogUrlResponseUnmarshaller.Instance;

            return BeginInvoke<GetGameSessionLogUrlRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGameSessionLogUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGameSessionLogUrl.</param>
        /// 
        /// <returns>Returns a  GetGameSessionLogUrlResult from GameLift.</returns>
        public  GetGameSessionLogUrlResponse EndGetGameSessionLogUrl(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGameSessionLogUrlResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAliases

        /// <summary>
        /// Retrieves a collection of alias records for this AWS account. You can filter the result
        /// set by alias name and/or routing strategy type. Use the pagination parameters to retrieve
        /// results in sequential pages. 
        /// 
        ///  <note>
        /// <para>
        /// Aliases are not listed in any particular order.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            var marshaller = new ListAliasesRequestMarshaller();
            var unmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAliasesRequest,ListAliasesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAliases
        ///         operation.</returns>
        public IAsyncResult BeginListAliases(ListAliasesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListAliasesRequestMarshaller();
            var unmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return BeginInvoke<ListAliasesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAliases.</param>
        /// 
        /// <returns>Returns a  ListAliasesResult from GameLift.</returns>
        public  ListAliasesResponse EndListAliases(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAliasesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBuilds

        /// <summary>
        /// Retrieves build records for all builds associated with an AWS account. You can filter
        /// the result set by build status. Use the pagination parameters to retrieve results
        /// in a set of sequential pages. 
        /// 
        ///  <note>
        /// <para>
        /// Build records are not listed in any particular order.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuilds service method.</param>
        /// 
        /// <returns>The response from the ListBuilds service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public ListBuildsResponse ListBuilds(ListBuildsRequest request)
        {
            var marshaller = new ListBuildsRequestMarshaller();
            var unmarshaller = ListBuildsResponseUnmarshaller.Instance;

            return Invoke<ListBuildsRequest,ListBuildsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuilds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuilds operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBuilds
        ///         operation.</returns>
        public IAsyncResult BeginListBuilds(ListBuildsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListBuildsRequestMarshaller();
            var unmarshaller = ListBuildsResponseUnmarshaller.Instance;

            return BeginInvoke<ListBuildsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBuilds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBuilds.</param>
        /// 
        /// <returns>Returns a  ListBuildsResult from GameLift.</returns>
        public  ListBuildsResponse EndListBuilds(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBuildsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFleets

        /// <summary>
        /// Retrieves a collection of fleet records for this AWS account. You can filter the result
        /// set by build ID. Use the pagination parameters to retrieve results in sequential pages.
        /// 
        /// 
        ///  <note>
        /// <para>
        /// Fleet records are not listed in any particular order.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleets service method.</param>
        /// 
        /// <returns>The response from the ListFleets service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public ListFleetsResponse ListFleets(ListFleetsRequest request)
        {
            var marshaller = new ListFleetsRequestMarshaller();
            var unmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return Invoke<ListFleetsRequest,ListFleetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleets operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFleets
        ///         operation.</returns>
        public IAsyncResult BeginListFleets(ListFleetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListFleetsRequestMarshaller();
            var unmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return BeginInvoke<ListFleetsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFleets.</param>
        /// 
        /// <returns>Returns a  ListFleetsResult from GameLift.</returns>
        public  ListFleetsResponse EndListFleets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFleetsResponse>(asyncResult);
        }

        #endregion
        
        #region  RequestUploadCredentials

        /// <summary>
        /// Retrieves a fresh set of upload credentials and the assigned Amazon S3 storage location
        /// for a specific build. Valid credentials are required to upload your game build files
        /// to Amazon S3.
        /// 
        ///  <important>
        /// <para>
        /// Call this action only if you need credentials for a build created with <a>CreateBuild</a>.
        /// This is a rare situation; in most cases, builds are created using the CLI command
        /// <code>upload-build</code>, which creates a build record and also uploads build files.
        /// 
        /// </para>
        /// </important> 
        /// <para>
        /// Upload credentials are returned when you create the build, but they have a limited
        /// lifespan. You can get fresh credentials and use them to re-upload game files until
        /// the state of that build changes to READY. Once this happens, you must create a brand
        /// new build.
        /// </para>
        /// </summary>
        /// <param name="buildId">Unique identifier for the build you want to get credentials for. </param>
        /// 
        /// <returns>The response from the RequestUploadCredentials service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public RequestUploadCredentialsResponse RequestUploadCredentials(string buildId)
        {
            var request = new RequestUploadCredentialsRequest();
            request.BuildId = buildId;
            return RequestUploadCredentials(request);
        }


        /// <summary>
        /// Retrieves a fresh set of upload credentials and the assigned Amazon S3 storage location
        /// for a specific build. Valid credentials are required to upload your game build files
        /// to Amazon S3.
        /// 
        ///  <important>
        /// <para>
        /// Call this action only if you need credentials for a build created with <a>CreateBuild</a>.
        /// This is a rare situation; in most cases, builds are created using the CLI command
        /// <code>upload-build</code>, which creates a build record and also uploads build files.
        /// 
        /// </para>
        /// </important> 
        /// <para>
        /// Upload credentials are returned when you create the build, but they have a limited
        /// lifespan. You can get fresh credentials and use them to re-upload game files until
        /// the state of that build changes to READY. Once this happens, you must create a brand
        /// new build.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestUploadCredentials service method.</param>
        /// 
        /// <returns>The response from the RequestUploadCredentials service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public RequestUploadCredentialsResponse RequestUploadCredentials(RequestUploadCredentialsRequest request)
        {
            var marshaller = new RequestUploadCredentialsRequestMarshaller();
            var unmarshaller = RequestUploadCredentialsResponseUnmarshaller.Instance;

            return Invoke<RequestUploadCredentialsRequest,RequestUploadCredentialsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RequestUploadCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestUploadCredentials operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRequestUploadCredentials
        ///         operation.</returns>
        public IAsyncResult BeginRequestUploadCredentials(RequestUploadCredentialsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RequestUploadCredentialsRequestMarshaller();
            var unmarshaller = RequestUploadCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke<RequestUploadCredentialsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RequestUploadCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestUploadCredentials.</param>
        /// 
        /// <returns>Returns a  RequestUploadCredentialsResult from GameLift.</returns>
        public  RequestUploadCredentialsResponse EndRequestUploadCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<RequestUploadCredentialsResponse>(asyncResult);
        }

        #endregion
        
        #region  ResolveAlias

        /// <summary>
        /// Retrieves the fleet ID that a specified alias is currently pointing to.
        /// </summary>
        /// <param name="aliasId">Unique identifier for the alias you want to resolve. </param>
        /// 
        /// <returns>The response from the ResolveAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public ResolveAliasResponse ResolveAlias(string aliasId)
        {
            var request = new ResolveAliasRequest();
            request.AliasId = aliasId;
            return ResolveAlias(request);
        }


        /// <summary>
        /// Retrieves the fleet ID that a specified alias is currently pointing to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResolveAlias service method.</param>
        /// 
        /// <returns>The response from the ResolveAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public ResolveAliasResponse ResolveAlias(ResolveAliasRequest request)
        {
            var marshaller = new ResolveAliasRequestMarshaller();
            var unmarshaller = ResolveAliasResponseUnmarshaller.Instance;

            return Invoke<ResolveAliasRequest,ResolveAliasResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResolveAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResolveAlias operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResolveAlias
        ///         operation.</returns>
        public IAsyncResult BeginResolveAlias(ResolveAliasRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ResolveAliasRequestMarshaller();
            var unmarshaller = ResolveAliasResponseUnmarshaller.Instance;

            return BeginInvoke<ResolveAliasRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResolveAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResolveAlias.</param>
        /// 
        /// <returns>Returns a  ResolveAliasResult from GameLift.</returns>
        public  ResolveAliasResponse EndResolveAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<ResolveAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAlias

        /// <summary>
        /// Updates properties for an alias. To update properties, specify the alias ID to be
        /// updated and provide the information to be changed. To reassign an alias to another
        /// fleet, provide an updated routing strategy. If successful, the updated alias record
        /// is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public UpdateAliasResponse UpdateAlias(UpdateAliasRequest request)
        {
            var marshaller = new UpdateAliasRequestMarshaller();
            var unmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateAliasRequest,UpdateAliasResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAlias
        ///         operation.</returns>
        public IAsyncResult BeginUpdateAlias(UpdateAliasRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateAliasRequestMarshaller();
            var unmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateAliasRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAlias.</param>
        /// 
        /// <returns>Returns a  UpdateAliasResult from GameLift.</returns>
        public  UpdateAliasResponse EndUpdateAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBuild

        /// <summary>
        /// Updates metadata in a build record, including the build name and version. To update
        /// the metadata, specify the build ID to update and provide the new values. If successful,
        /// a build object containing the updated metadata is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBuild service method.</param>
        /// 
        /// <returns>The response from the UpdateBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public UpdateBuildResponse UpdateBuild(UpdateBuildRequest request)
        {
            var marshaller = new UpdateBuildRequestMarshaller();
            var unmarshaller = UpdateBuildResponseUnmarshaller.Instance;

            return Invoke<UpdateBuildRequest,UpdateBuildResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBuild operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBuild
        ///         operation.</returns>
        public IAsyncResult BeginUpdateBuild(UpdateBuildRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateBuildRequestMarshaller();
            var unmarshaller = UpdateBuildResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateBuildRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBuild operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBuild.</param>
        /// 
        /// <returns>Returns a  UpdateBuildResult from GameLift.</returns>
        public  UpdateBuildResponse EndUpdateBuild(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBuildResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFleetAttributes

        /// <summary>
        /// Updates fleet properties, including name and description, for a fleet. To update metadata,
        /// specify the fleet ID and the property values you want to change. If successful, the
        /// fleet ID for the updated fleet is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetAttributes service method.</param>
        /// 
        /// <returns>The response from the UpdateFleetAttributes service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Please resolve the conflict before retrying
        /// this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Please resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Please resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public UpdateFleetAttributesResponse UpdateFleetAttributes(UpdateFleetAttributesRequest request)
        {
            var marshaller = new UpdateFleetAttributesRequestMarshaller();
            var unmarshaller = UpdateFleetAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetAttributesRequest,UpdateFleetAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleetAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetAttributes operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFleetAttributes
        ///         operation.</returns>
        public IAsyncResult BeginUpdateFleetAttributes(UpdateFleetAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateFleetAttributesRequestMarshaller();
            var unmarshaller = UpdateFleetAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateFleetAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFleetAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFleetAttributes.</param>
        /// 
        /// <returns>Returns a  UpdateFleetAttributesResult from GameLift.</returns>
        public  UpdateFleetAttributesResponse EndUpdateFleetAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFleetAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFleetCapacity

        /// <summary>
        /// Updates capacity settings for a fleet. Use this action to specify the number of EC2
        /// instances (hosts) you want this fleet to contain. Before calling this action, you
        /// may want to call <a>DescribeEC2InstanceLimits</a> to get the maximum capacity based
        /// on the fleet's EC2 instance type.
        /// 
        ///  
        /// <para>
        /// To update fleet capacity, specify the fleet ID and the desired number of instances.
        /// If successful, Amazon GameLift starts or terminates instances so that the fleet's
        /// active instance count matches the desired instance count. You can view a fleet's current
        /// capacity information by calling <a>DescribeFleetCapacity</a>. If the desired instance
        /// count is higher than the instance type's limit, the "Limit Exceeded" exception will
        /// occur.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetCapacity service method.</param>
        /// 
        /// <returns>The response from the UpdateFleetCapacity service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Please resolve the conflict before retrying
        /// this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Please resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Please resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public UpdateFleetCapacityResponse UpdateFleetCapacity(UpdateFleetCapacityRequest request)
        {
            var marshaller = new UpdateFleetCapacityRequestMarshaller();
            var unmarshaller = UpdateFleetCapacityResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetCapacityRequest,UpdateFleetCapacityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleetCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetCapacity operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFleetCapacity
        ///         operation.</returns>
        public IAsyncResult BeginUpdateFleetCapacity(UpdateFleetCapacityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateFleetCapacityRequestMarshaller();
            var unmarshaller = UpdateFleetCapacityResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateFleetCapacityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFleetCapacity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFleetCapacity.</param>
        /// 
        /// <returns>Returns a  UpdateFleetCapacityResult from GameLift.</returns>
        public  UpdateFleetCapacityResponse EndUpdateFleetCapacity(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFleetCapacityResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFleetPortSettings

        /// <summary>
        /// Updates port settings for a fleet. To update settings, specify the fleet ID to be
        /// updated and list the permissions you want to update. List the permissions you want
        /// to add in <i>InboundPermissionAuthorizations</i>, and permissions you want to remove
        /// in <i>InboundPermissionRevocations</i>. Permissions to be removed must match existing
        /// fleet permissions. If successful, the fleet ID for the updated fleet is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetPortSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateFleetPortSettings service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Please resolve the conflict before retrying
        /// this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Please resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Please resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public UpdateFleetPortSettingsResponse UpdateFleetPortSettings(UpdateFleetPortSettingsRequest request)
        {
            var marshaller = new UpdateFleetPortSettingsRequestMarshaller();
            var unmarshaller = UpdateFleetPortSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetPortSettingsRequest,UpdateFleetPortSettingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleetPortSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetPortSettings operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFleetPortSettings
        ///         operation.</returns>
        public IAsyncResult BeginUpdateFleetPortSettings(UpdateFleetPortSettingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateFleetPortSettingsRequestMarshaller();
            var unmarshaller = UpdateFleetPortSettingsResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateFleetPortSettingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFleetPortSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFleetPortSettings.</param>
        /// 
        /// <returns>Returns a  UpdateFleetPortSettingsResult from GameLift.</returns>
        public  UpdateFleetPortSettingsResponse EndUpdateFleetPortSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFleetPortSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGameSession

        /// <summary>
        /// Updates game session properties. This includes the session name, maximum player count
        /// and the player session creation policy, which either allows or denies new players
        /// from joining the session. To update a game session, specify the game session ID and
        /// the values you want to change. If successful, an updated <a>GameSession</a> object
        /// is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameSession service method.</param>
        /// 
        /// <returns>The response from the UpdateGameSession service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Please resolve the conflict before retrying
        /// this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Such requests should not be
        /// retried by clients without resolving the conflict.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        public UpdateGameSessionResponse UpdateGameSession(UpdateGameSessionRequest request)
        {
            var marshaller = new UpdateGameSessionRequestMarshaller();
            var unmarshaller = UpdateGameSessionResponseUnmarshaller.Instance;

            return Invoke<UpdateGameSessionRequest,UpdateGameSessionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGameSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameSession operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGameSession
        ///         operation.</returns>
        public IAsyncResult BeginUpdateGameSession(UpdateGameSessionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateGameSessionRequestMarshaller();
            var unmarshaller = UpdateGameSessionResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateGameSessionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGameSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGameSession.</param>
        /// 
        /// <returns>Returns a  UpdateGameSessionResult from GameLift.</returns>
        public  UpdateGameSessionResponse EndUpdateGameSession(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGameSessionResponse>(asyncResult);
        }

        #endregion
        
    }
}