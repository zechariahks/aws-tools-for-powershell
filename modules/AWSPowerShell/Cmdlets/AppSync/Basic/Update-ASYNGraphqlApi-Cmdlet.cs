/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.AppSync;
using Amazon.AppSync.Model;

namespace Amazon.PowerShell.Cmdlets.ASYN
{
    /// <summary>
    /// Updates a <code>GraphqlApi</code> object.
    /// </summary>
    [Cmdlet("Update", "ASYNGraphqlApi", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.AppSync.Model.GraphqlApi")]
    [AWSCmdlet("Calls the AWS AppSync UpdateGraphqlApi API operation.", Operation = new[] {"UpdateGraphqlApi"}, SelectReturnType = typeof(Amazon.AppSync.Model.UpdateGraphqlApiResponse))]
    [AWSCmdletOutput("Amazon.AppSync.Model.GraphqlApi or Amazon.AppSync.Model.UpdateGraphqlApiResponse",
        "This cmdlet returns an Amazon.AppSync.Model.GraphqlApi object.",
        "The service call response (type Amazon.AppSync.Model.UpdateGraphqlApiResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class UpdateASYNGraphqlApiCmdlet : AmazonAppSyncClientCmdlet, IExecutor
    {
        
        #region Parameter AdditionalAuthenticationProvider
        /// <summary>
        /// <para>
        /// <para>A list of additional authentication providers for the <code>GraphqlApi</code> API.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AdditionalAuthenticationProviders")]
        public Amazon.AppSync.Model.AdditionalAuthenticationProvider[] AdditionalAuthenticationProvider { get; set; }
        #endregion
        
        #region Parameter ApiId
        /// <summary>
        /// <para>
        /// <para>The API ID.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String ApiId { get; set; }
        #endregion
        
        #region Parameter AuthenticationType
        /// <summary>
        /// <para>
        /// <para>The new authentication type for the <code>GraphqlApi</code> object.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.AppSync.AuthenticationType")]
        public Amazon.AppSync.AuthenticationType AuthenticationType { get; set; }
        #endregion
        
        #region Parameter LambdaAuthorizerConfig_AuthorizerResultTtlInSecond
        /// <summary>
        /// <para>
        /// <para>The number of seconds a response should be cached for. The default is 5 minutes (300
        /// seconds). The Lambda function can override this by returning a <code>ttlOverride</code>
        /// key in its response. A value of 0 disables caching of responses.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("LambdaAuthorizerConfig_AuthorizerResultTtlInSeconds")]
        public System.Int32? LambdaAuthorizerConfig_AuthorizerResultTtlInSecond { get; set; }
        #endregion
        
        #region Parameter LambdaAuthorizerConfig_AuthorizerUri
        /// <summary>
        /// <para>
        /// <para>The ARN of the Lambda function to be called for authorization. This may be a standard
        /// Lambda ARN, a version ARN (<code>.../v3</code>) or alias ARN. </para><para><i>Note</i>: This Lambda function must have the following resource-based policy assigned
        /// to it. When configuring Lambda authorizers in the Console, this is done for you. To
        /// do so with the Amazon Web Services CLI, run the following:</para><para><code>aws lambda add-permission --function-name "arn:aws:lambda:us-east-2:111122223333:function:my-function"
        /// --statement-id "appsync" --principal appsync.amazonaws.com --action lambda:InvokeFunction</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String LambdaAuthorizerConfig_AuthorizerUri { get; set; }
        #endregion
        
        #region Parameter OpenIDConnectConfig_AuthTTL
        /// <summary>
        /// <para>
        /// <para>The number of milliseconds a token is valid after being authenticated.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int64? OpenIDConnectConfig_AuthTTL { get; set; }
        #endregion
        
        #region Parameter OpenIDConnectConfig_ClientId
        /// <summary>
        /// <para>
        /// <para>The client identifier of the Relying party at the OpenID identity provider. This identifier
        /// is typically obtained when the Relying party is registered with the OpenID identity
        /// provider. You can specify a regular expression so the AppSync can validate against
        /// multiple client identifiers at a time.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String OpenIDConnectConfig_ClientId { get; set; }
        #endregion
        
        #region Parameter LogConfig_CloudWatchLogsRoleArn
        /// <summary>
        /// <para>
        /// <para>The service role that AppSync will assume to publish to Amazon CloudWatch logs in
        /// your account. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String LogConfig_CloudWatchLogsRoleArn { get; set; }
        #endregion
        
        #region Parameter LogConfig_ExcludeVerboseContent
        /// <summary>
        /// <para>
        /// <para>Set to TRUE to exclude sections that contain information such as headers, context,
        /// and evaluated mapping templates, regardless of logging level.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? LogConfig_ExcludeVerboseContent { get; set; }
        #endregion
        
        #region Parameter LogConfig_FieldLogLevel
        /// <summary>
        /// <para>
        /// <para>The field logging level. Values can be NONE, ERROR, or ALL. </para><ul><li><para><b>NONE</b>: No field-level logs are captured.</para></li><li><para><b>ERROR</b>: Logs the following information only for the fields that are in error:</para><ul><li><para>The error section in the server response.</para></li><li><para>Field-level errors.</para></li><li><para>The generated request/response functions that got resolved for error fields.</para></li></ul></li><li><para><b>ALL</b>: The following information is logged for all fields in the query:</para><ul><li><para>Field-level tracing information.</para></li><li><para>The generated request/response functions that got resolved for each field.</para></li></ul></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.AppSync.FieldLogLevel")]
        public Amazon.AppSync.FieldLogLevel LogConfig_FieldLogLevel { get; set; }
        #endregion
        
        #region Parameter OpenIDConnectConfig_IatTTL
        /// <summary>
        /// <para>
        /// <para>The number of milliseconds a token is valid after being issued to a user.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int64? OpenIDConnectConfig_IatTTL { get; set; }
        #endregion
        
        #region Parameter LambdaAuthorizerConfig_IdentityValidationExpression
        /// <summary>
        /// <para>
        /// <para>A regular expression for validation of tokens before the Lambda function is called.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String LambdaAuthorizerConfig_IdentityValidationExpression { get; set; }
        #endregion
        
        #region Parameter OpenIDConnectConfig_Issuer
        /// <summary>
        /// <para>
        /// <para>The issuer for the OpenID Connect configuration. The issuer returned by discovery
        /// must exactly match the value of <code>iss</code> in the ID token.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String OpenIDConnectConfig_Issuer { get; set; }
        #endregion
        
        #region Parameter Name
        /// <summary>
        /// <para>
        /// <para>The new name for the <code>GraphqlApi</code> object.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String Name { get; set; }
        #endregion
        
        #region Parameter UserPoolConfig
        /// <summary>
        /// <para>
        /// <para>The new Amazon Cognito user pool configuration for the <code>GraphqlApi</code> object.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.AppSync.Model.UserPoolConfig UserPoolConfig { get; set; }
        #endregion
        
        #region Parameter XrayEnabled
        /// <summary>
        /// <para>
        /// <para>A flag indicating whether to enable X-Ray tracing for the <code>GraphqlApi</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? XrayEnabled { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'GraphqlApi'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.AppSync.Model.UpdateGraphqlApiResponse).
        /// Specifying the name of a property of type Amazon.AppSync.Model.UpdateGraphqlApiResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "GraphqlApi";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Name parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Name' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Name' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter Force
        /// <summary>
        /// This parameter overrides confirmation prompts to force 
        /// the cmdlet to continue its operation. This parameter should always
        /// be used with caution.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter Force { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.Name), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-ASYNGraphqlApi (UpdateGraphqlApi)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.AppSync.Model.UpdateGraphqlApiResponse, UpdateASYNGraphqlApiCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Name;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (this.AdditionalAuthenticationProvider != null)
            {
                context.AdditionalAuthenticationProvider = new List<Amazon.AppSync.Model.AdditionalAuthenticationProvider>(this.AdditionalAuthenticationProvider);
            }
            context.ApiId = this.ApiId;
            #if MODULAR
            if (this.ApiId == null && ParameterWasBound(nameof(this.ApiId)))
            {
                WriteWarning("You are passing $null as a value for parameter ApiId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.AuthenticationType = this.AuthenticationType;
            context.LambdaAuthorizerConfig_AuthorizerResultTtlInSecond = this.LambdaAuthorizerConfig_AuthorizerResultTtlInSecond;
            context.LambdaAuthorizerConfig_AuthorizerUri = this.LambdaAuthorizerConfig_AuthorizerUri;
            context.LambdaAuthorizerConfig_IdentityValidationExpression = this.LambdaAuthorizerConfig_IdentityValidationExpression;
            context.LogConfig_CloudWatchLogsRoleArn = this.LogConfig_CloudWatchLogsRoleArn;
            context.LogConfig_ExcludeVerboseContent = this.LogConfig_ExcludeVerboseContent;
            context.LogConfig_FieldLogLevel = this.LogConfig_FieldLogLevel;
            context.Name = this.Name;
            #if MODULAR
            if (this.Name == null && ParameterWasBound(nameof(this.Name)))
            {
                WriteWarning("You are passing $null as a value for parameter Name which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.OpenIDConnectConfig_AuthTTL = this.OpenIDConnectConfig_AuthTTL;
            context.OpenIDConnectConfig_ClientId = this.OpenIDConnectConfig_ClientId;
            context.OpenIDConnectConfig_IatTTL = this.OpenIDConnectConfig_IatTTL;
            context.OpenIDConnectConfig_Issuer = this.OpenIDConnectConfig_Issuer;
            context.UserPoolConfig = this.UserPoolConfig;
            context.XrayEnabled = this.XrayEnabled;
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.AppSync.Model.UpdateGraphqlApiRequest();
            
            if (cmdletContext.AdditionalAuthenticationProvider != null)
            {
                request.AdditionalAuthenticationProviders = cmdletContext.AdditionalAuthenticationProvider;
            }
            if (cmdletContext.ApiId != null)
            {
                request.ApiId = cmdletContext.ApiId;
            }
            if (cmdletContext.AuthenticationType != null)
            {
                request.AuthenticationType = cmdletContext.AuthenticationType;
            }
            
             // populate LambdaAuthorizerConfig
            var requestLambdaAuthorizerConfigIsNull = true;
            request.LambdaAuthorizerConfig = new Amazon.AppSync.Model.LambdaAuthorizerConfig();
            System.Int32? requestLambdaAuthorizerConfig_lambdaAuthorizerConfig_AuthorizerResultTtlInSecond = null;
            if (cmdletContext.LambdaAuthorizerConfig_AuthorizerResultTtlInSecond != null)
            {
                requestLambdaAuthorizerConfig_lambdaAuthorizerConfig_AuthorizerResultTtlInSecond = cmdletContext.LambdaAuthorizerConfig_AuthorizerResultTtlInSecond.Value;
            }
            if (requestLambdaAuthorizerConfig_lambdaAuthorizerConfig_AuthorizerResultTtlInSecond != null)
            {
                request.LambdaAuthorizerConfig.AuthorizerResultTtlInSeconds = requestLambdaAuthorizerConfig_lambdaAuthorizerConfig_AuthorizerResultTtlInSecond.Value;
                requestLambdaAuthorizerConfigIsNull = false;
            }
            System.String requestLambdaAuthorizerConfig_lambdaAuthorizerConfig_AuthorizerUri = null;
            if (cmdletContext.LambdaAuthorizerConfig_AuthorizerUri != null)
            {
                requestLambdaAuthorizerConfig_lambdaAuthorizerConfig_AuthorizerUri = cmdletContext.LambdaAuthorizerConfig_AuthorizerUri;
            }
            if (requestLambdaAuthorizerConfig_lambdaAuthorizerConfig_AuthorizerUri != null)
            {
                request.LambdaAuthorizerConfig.AuthorizerUri = requestLambdaAuthorizerConfig_lambdaAuthorizerConfig_AuthorizerUri;
                requestLambdaAuthorizerConfigIsNull = false;
            }
            System.String requestLambdaAuthorizerConfig_lambdaAuthorizerConfig_IdentityValidationExpression = null;
            if (cmdletContext.LambdaAuthorizerConfig_IdentityValidationExpression != null)
            {
                requestLambdaAuthorizerConfig_lambdaAuthorizerConfig_IdentityValidationExpression = cmdletContext.LambdaAuthorizerConfig_IdentityValidationExpression;
            }
            if (requestLambdaAuthorizerConfig_lambdaAuthorizerConfig_IdentityValidationExpression != null)
            {
                request.LambdaAuthorizerConfig.IdentityValidationExpression = requestLambdaAuthorizerConfig_lambdaAuthorizerConfig_IdentityValidationExpression;
                requestLambdaAuthorizerConfigIsNull = false;
            }
             // determine if request.LambdaAuthorizerConfig should be set to null
            if (requestLambdaAuthorizerConfigIsNull)
            {
                request.LambdaAuthorizerConfig = null;
            }
            
             // populate LogConfig
            var requestLogConfigIsNull = true;
            request.LogConfig = new Amazon.AppSync.Model.LogConfig();
            System.String requestLogConfig_logConfig_CloudWatchLogsRoleArn = null;
            if (cmdletContext.LogConfig_CloudWatchLogsRoleArn != null)
            {
                requestLogConfig_logConfig_CloudWatchLogsRoleArn = cmdletContext.LogConfig_CloudWatchLogsRoleArn;
            }
            if (requestLogConfig_logConfig_CloudWatchLogsRoleArn != null)
            {
                request.LogConfig.CloudWatchLogsRoleArn = requestLogConfig_logConfig_CloudWatchLogsRoleArn;
                requestLogConfigIsNull = false;
            }
            System.Boolean? requestLogConfig_logConfig_ExcludeVerboseContent = null;
            if (cmdletContext.LogConfig_ExcludeVerboseContent != null)
            {
                requestLogConfig_logConfig_ExcludeVerboseContent = cmdletContext.LogConfig_ExcludeVerboseContent.Value;
            }
            if (requestLogConfig_logConfig_ExcludeVerboseContent != null)
            {
                request.LogConfig.ExcludeVerboseContent = requestLogConfig_logConfig_ExcludeVerboseContent.Value;
                requestLogConfigIsNull = false;
            }
            Amazon.AppSync.FieldLogLevel requestLogConfig_logConfig_FieldLogLevel = null;
            if (cmdletContext.LogConfig_FieldLogLevel != null)
            {
                requestLogConfig_logConfig_FieldLogLevel = cmdletContext.LogConfig_FieldLogLevel;
            }
            if (requestLogConfig_logConfig_FieldLogLevel != null)
            {
                request.LogConfig.FieldLogLevel = requestLogConfig_logConfig_FieldLogLevel;
                requestLogConfigIsNull = false;
            }
             // determine if request.LogConfig should be set to null
            if (requestLogConfigIsNull)
            {
                request.LogConfig = null;
            }
            if (cmdletContext.Name != null)
            {
                request.Name = cmdletContext.Name;
            }
            
             // populate OpenIDConnectConfig
            var requestOpenIDConnectConfigIsNull = true;
            request.OpenIDConnectConfig = new Amazon.AppSync.Model.OpenIDConnectConfig();
            System.Int64? requestOpenIDConnectConfig_openIDConnectConfig_AuthTTL = null;
            if (cmdletContext.OpenIDConnectConfig_AuthTTL != null)
            {
                requestOpenIDConnectConfig_openIDConnectConfig_AuthTTL = cmdletContext.OpenIDConnectConfig_AuthTTL.Value;
            }
            if (requestOpenIDConnectConfig_openIDConnectConfig_AuthTTL != null)
            {
                request.OpenIDConnectConfig.AuthTTL = requestOpenIDConnectConfig_openIDConnectConfig_AuthTTL.Value;
                requestOpenIDConnectConfigIsNull = false;
            }
            System.String requestOpenIDConnectConfig_openIDConnectConfig_ClientId = null;
            if (cmdletContext.OpenIDConnectConfig_ClientId != null)
            {
                requestOpenIDConnectConfig_openIDConnectConfig_ClientId = cmdletContext.OpenIDConnectConfig_ClientId;
            }
            if (requestOpenIDConnectConfig_openIDConnectConfig_ClientId != null)
            {
                request.OpenIDConnectConfig.ClientId = requestOpenIDConnectConfig_openIDConnectConfig_ClientId;
                requestOpenIDConnectConfigIsNull = false;
            }
            System.Int64? requestOpenIDConnectConfig_openIDConnectConfig_IatTTL = null;
            if (cmdletContext.OpenIDConnectConfig_IatTTL != null)
            {
                requestOpenIDConnectConfig_openIDConnectConfig_IatTTL = cmdletContext.OpenIDConnectConfig_IatTTL.Value;
            }
            if (requestOpenIDConnectConfig_openIDConnectConfig_IatTTL != null)
            {
                request.OpenIDConnectConfig.IatTTL = requestOpenIDConnectConfig_openIDConnectConfig_IatTTL.Value;
                requestOpenIDConnectConfigIsNull = false;
            }
            System.String requestOpenIDConnectConfig_openIDConnectConfig_Issuer = null;
            if (cmdletContext.OpenIDConnectConfig_Issuer != null)
            {
                requestOpenIDConnectConfig_openIDConnectConfig_Issuer = cmdletContext.OpenIDConnectConfig_Issuer;
            }
            if (requestOpenIDConnectConfig_openIDConnectConfig_Issuer != null)
            {
                request.OpenIDConnectConfig.Issuer = requestOpenIDConnectConfig_openIDConnectConfig_Issuer;
                requestOpenIDConnectConfigIsNull = false;
            }
             // determine if request.OpenIDConnectConfig should be set to null
            if (requestOpenIDConnectConfigIsNull)
            {
                request.OpenIDConnectConfig = null;
            }
            if (cmdletContext.UserPoolConfig != null)
            {
                request.UserPoolConfig = cmdletContext.UserPoolConfig;
            }
            if (cmdletContext.XrayEnabled != null)
            {
                request.XrayEnabled = cmdletContext.XrayEnabled.Value;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.AppSync.Model.UpdateGraphqlApiResponse CallAWSServiceOperation(IAmazonAppSync client, Amazon.AppSync.Model.UpdateGraphqlApiRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS AppSync", "UpdateGraphqlApi");
            try
            {
                #if DESKTOP
                return client.UpdateGraphqlApi(request);
                #elif CORECLR
                return client.UpdateGraphqlApiAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public List<Amazon.AppSync.Model.AdditionalAuthenticationProvider> AdditionalAuthenticationProvider { get; set; }
            public System.String ApiId { get; set; }
            public Amazon.AppSync.AuthenticationType AuthenticationType { get; set; }
            public System.Int32? LambdaAuthorizerConfig_AuthorizerResultTtlInSecond { get; set; }
            public System.String LambdaAuthorizerConfig_AuthorizerUri { get; set; }
            public System.String LambdaAuthorizerConfig_IdentityValidationExpression { get; set; }
            public System.String LogConfig_CloudWatchLogsRoleArn { get; set; }
            public System.Boolean? LogConfig_ExcludeVerboseContent { get; set; }
            public Amazon.AppSync.FieldLogLevel LogConfig_FieldLogLevel { get; set; }
            public System.String Name { get; set; }
            public System.Int64? OpenIDConnectConfig_AuthTTL { get; set; }
            public System.String OpenIDConnectConfig_ClientId { get; set; }
            public System.Int64? OpenIDConnectConfig_IatTTL { get; set; }
            public System.String OpenIDConnectConfig_Issuer { get; set; }
            public Amazon.AppSync.Model.UserPoolConfig UserPoolConfig { get; set; }
            public System.Boolean? XrayEnabled { get; set; }
            public System.Func<Amazon.AppSync.Model.UpdateGraphqlApiResponse, UpdateASYNGraphqlApiCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.GraphqlApi;
        }
        
    }
}
