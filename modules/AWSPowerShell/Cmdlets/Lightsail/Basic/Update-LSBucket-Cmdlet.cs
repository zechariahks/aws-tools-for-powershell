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
using Amazon.Lightsail;
using Amazon.Lightsail.Model;

namespace Amazon.PowerShell.Cmdlets.LS
{
    /// <summary>
    /// Updates an existing Amazon Lightsail bucket.
    /// 
    ///  
    /// <para>
    /// Use this action to update the configuration of an existing bucket, such as versioning,
    /// public accessibility, and the AWS accounts that can access the bucket.
    /// </para>
    /// </summary>
    [Cmdlet("Update", "LSBucket", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.Lightsail.Model.UpdateBucketResponse")]
    [AWSCmdlet("Calls the Amazon Lightsail UpdateBucket API operation.", Operation = new[] {"UpdateBucket"}, SelectReturnType = typeof(Amazon.Lightsail.Model.UpdateBucketResponse))]
    [AWSCmdletOutput("Amazon.Lightsail.Model.UpdateBucketResponse",
        "This cmdlet returns an Amazon.Lightsail.Model.UpdateBucketResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class UpdateLSBucketCmdlet : AmazonLightsailClientCmdlet, IExecutor
    {
        
        #region Parameter AccessRules_AllowPublicOverride
        /// <summary>
        /// <para>
        /// <para>A Boolean value that indicates whether the access control list (ACL) permissions that
        /// are applied to individual objects override the <code>getObject</code> option that
        /// is currently specified.</para><para>When this is true, you can use the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObjectAcl.html">PutObjectAcl</a>
        /// Amazon S3 API action to set individual objects to public (read-only) using the <code>public-read</code>
        /// ACL, or to private using the <code>private</code> ACL.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AccessRules_AllowPublicOverrides")]
        public System.Boolean? AccessRules_AllowPublicOverride { get; set; }
        #endregion
        
        #region Parameter BucketName
        /// <summary>
        /// <para>
        /// <para>The name of the bucket to update.</para>
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
        public System.String BucketName { get; set; }
        #endregion
        
        #region Parameter AccessRules_GetObject
        /// <summary>
        /// <para>
        /// <para>Specifies the anonymous access to all objects in a bucket.</para><para>The following options can be specified:</para><ul><li><para><code>public</code> - Sets all objects in the bucket to public (read-only), making
        /// them readable by anyone in the world.</para><para>If the <code>getObject</code> value is set to <code>public</code>, then all objects
        /// in the bucket default to public regardless of the <code>allowPublicOverrides</code>
        /// value.</para></li><li><para><code>private</code> - Sets all objects in the bucket to private, making them readable
        /// only by you or anyone you give access to.</para><para>If the <code>getObject</code> value is set to <code>private</code>, and the <code>allowPublicOverrides</code>
        /// value is set to <code>true</code>, then all objects in the bucket default to private
        /// unless they are configured with a <code>public-read</code> ACL. Individual objects
        /// with a <code>public-read</code> ACL are readable by anyone in the world.</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.Lightsail.AccessType")]
        public Amazon.Lightsail.AccessType AccessRules_GetObject { get; set; }
        #endregion
        
        #region Parameter ReadonlyAccessAccount
        /// <summary>
        /// <para>
        /// <para>An array of strings to specify the AWS account IDs that can access the bucket.</para><para>You can give a maximum of 10 AWS accounts access to a bucket.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ReadonlyAccessAccounts")]
        public System.String[] ReadonlyAccessAccount { get; set; }
        #endregion
        
        #region Parameter Versioning
        /// <summary>
        /// <para>
        /// <para>Specifies whether to enable or suspend versioning of objects in the bucket.</para><para>The following options can be specified:</para><ul><li><para><code>Enabled</code> - Enables versioning of objects in the specified bucket.</para></li><li><para><code>Suspended</code> - Suspends versioning of objects in the specified bucket.
        /// Existing object versions are retained.</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Versioning { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Lightsail.Model.UpdateBucketResponse).
        /// Specifying the name of a property of type Amazon.Lightsail.Model.UpdateBucketResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the BucketName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^BucketName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^BucketName' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.BucketName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-LSBucket (UpdateBucket)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Lightsail.Model.UpdateBucketResponse, UpdateLSBucketCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.BucketName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AccessRules_AllowPublicOverride = this.AccessRules_AllowPublicOverride;
            context.AccessRules_GetObject = this.AccessRules_GetObject;
            context.BucketName = this.BucketName;
            #if MODULAR
            if (this.BucketName == null && ParameterWasBound(nameof(this.BucketName)))
            {
                WriteWarning("You are passing $null as a value for parameter BucketName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.ReadonlyAccessAccount != null)
            {
                context.ReadonlyAccessAccount = new List<System.String>(this.ReadonlyAccessAccount);
            }
            context.Versioning = this.Versioning;
            
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
            var request = new Amazon.Lightsail.Model.UpdateBucketRequest();
            
            
             // populate AccessRules
            var requestAccessRulesIsNull = true;
            request.AccessRules = new Amazon.Lightsail.Model.AccessRules();
            System.Boolean? requestAccessRules_accessRules_AllowPublicOverride = null;
            if (cmdletContext.AccessRules_AllowPublicOverride != null)
            {
                requestAccessRules_accessRules_AllowPublicOverride = cmdletContext.AccessRules_AllowPublicOverride.Value;
            }
            if (requestAccessRules_accessRules_AllowPublicOverride != null)
            {
                request.AccessRules.AllowPublicOverrides = requestAccessRules_accessRules_AllowPublicOverride.Value;
                requestAccessRulesIsNull = false;
            }
            Amazon.Lightsail.AccessType requestAccessRules_accessRules_GetObject = null;
            if (cmdletContext.AccessRules_GetObject != null)
            {
                requestAccessRules_accessRules_GetObject = cmdletContext.AccessRules_GetObject;
            }
            if (requestAccessRules_accessRules_GetObject != null)
            {
                request.AccessRules.GetObject = requestAccessRules_accessRules_GetObject;
                requestAccessRulesIsNull = false;
            }
             // determine if request.AccessRules should be set to null
            if (requestAccessRulesIsNull)
            {
                request.AccessRules = null;
            }
            if (cmdletContext.BucketName != null)
            {
                request.BucketName = cmdletContext.BucketName;
            }
            if (cmdletContext.ReadonlyAccessAccount != null)
            {
                request.ReadonlyAccessAccounts = cmdletContext.ReadonlyAccessAccount;
            }
            if (cmdletContext.Versioning != null)
            {
                request.Versioning = cmdletContext.Versioning;
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
        
        private Amazon.Lightsail.Model.UpdateBucketResponse CallAWSServiceOperation(IAmazonLightsail client, Amazon.Lightsail.Model.UpdateBucketRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Lightsail", "UpdateBucket");
            try
            {
                #if DESKTOP
                return client.UpdateBucket(request);
                #elif CORECLR
                return client.UpdateBucketAsync(request).GetAwaiter().GetResult();
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
            public System.Boolean? AccessRules_AllowPublicOverride { get; set; }
            public Amazon.Lightsail.AccessType AccessRules_GetObject { get; set; }
            public System.String BucketName { get; set; }
            public List<System.String> ReadonlyAccessAccount { get; set; }
            public System.String Versioning { get; set; }
            public System.Func<Amazon.Lightsail.Model.UpdateBucketResponse, UpdateLSBucketCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
