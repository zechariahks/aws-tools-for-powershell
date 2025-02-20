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
using Amazon.Kendra;
using Amazon.Kendra.Model;

namespace Amazon.PowerShell.Cmdlets.KNDR
{
    /// <summary>
    /// Creates a new Amazon Kendra index. Index creation is an asynchronous operation. To
    /// determine if index creation has completed, check the <code>Status</code> field returned
    /// from a call to <code>DescribeIndex</code>. The <code>Status</code> field is set to
    /// <code>ACTIVE</code> when the index is ready to use.
    /// 
    ///  
    /// <para>
    /// Once the index is active you can index your documents using the <code>BatchPutDocument</code>
    /// operation or using one of the supported data sources. 
    /// </para>
    /// </summary>
    [Cmdlet("New", "KNDRIndex", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the Amazon Kendra CreateIndex API operation.", Operation = new[] {"CreateIndex"}, SelectReturnType = typeof(Amazon.Kendra.Model.CreateIndexResponse))]
    [AWSCmdletOutput("System.String or Amazon.Kendra.Model.CreateIndexResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.Kendra.Model.CreateIndexResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewKNDRIndexCmdlet : AmazonKendraClientCmdlet, IExecutor
    {
        
        #region Parameter Description
        /// <summary>
        /// <para>
        /// <para>A description for the index.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Description { get; set; }
        #endregion
        
        #region Parameter Edition
        /// <summary>
        /// <para>
        /// <para>The Amazon Kendra edition to use for the index. Choose <code>DEVELOPER_EDITION</code>
        /// for indexes intended for development, testing, or proof of concept. Use <code>ENTERPRISE_EDITION</code>
        /// for your production databases. Once you set the edition for an index, it can't be
        /// changed.</para><para>The <code>Edition</code> parameter is optional. If you don't supply a value, the default
        /// is <code>ENTERPRISE_EDITION</code>.</para><para>For more information on quota limits for enterprise and developer editions, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.Kendra.IndexEdition")]
        public Amazon.Kendra.IndexEdition Edition { get; set; }
        #endregion
        
        #region Parameter ServerSideEncryptionConfiguration_KmsKeyId
        /// <summary>
        /// <para>
        /// <para>The identifier of the KMScustomer master key (CMK). Amazon Kendra doesn't support
        /// asymmetric CMKs.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ServerSideEncryptionConfiguration_KmsKeyId { get; set; }
        #endregion
        
        #region Parameter Name
        /// <summary>
        /// <para>
        /// <para>The name for the new index.</para>
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
        
        #region Parameter RoleArn
        /// <summary>
        /// <para>
        /// <para>An Identity and Access Management(IAM) role that gives Amazon Kendra permissions to
        /// access your Amazon CloudWatch logs and metrics. This is also the role used when you
        /// use the <code>BatchPutDocument</code> operation to index documents from an Amazon
        /// S3 bucket.</para>
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
        public System.String RoleArn { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>A list of key-value pairs that identify the index. You can use the tags to identify
        /// and organize your resources and to control access to resources.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.Kendra.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter UserContextPolicy
        /// <summary>
        /// <para>
        /// <para>The user context policy.</para><dl><dt>ATTRIBUTE_FILTER</dt><dd><para>All indexed content is searchable and displayable for all users. If there is an access
        /// control list, it is ignored. You can filter on user and group attributes. </para></dd><dt>USER_TOKEN</dt><dd><para>Enables SSO and token-based user access control. All documents with no access control
        /// and all documents accessible to the user will be searchable and displayable. </para></dd></dl>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.Kendra.UserContextPolicy")]
        public Amazon.Kendra.UserContextPolicy UserContextPolicy { get; set; }
        #endregion
        
        #region Parameter UserTokenConfiguration
        /// <summary>
        /// <para>
        /// <para>The user token configuration.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("UserTokenConfigurations")]
        public Amazon.Kendra.Model.UserTokenConfiguration[] UserTokenConfiguration { get; set; }
        #endregion
        
        #region Parameter ClientToken
        /// <summary>
        /// <para>
        /// <para>A token that you provide to identify the request to create an index. Multiple calls
        /// to the <code>CreateIndex</code> operation with the same client token will create only
        /// one index.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Id'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Kendra.Model.CreateIndexResponse).
        /// Specifying the name of a property of type Amazon.Kendra.Model.CreateIndexResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Id";
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
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-KNDRIndex (CreateIndex)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Kendra.Model.CreateIndexResponse, NewKNDRIndexCmdlet>(Select) ??
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
            context.ClientToken = this.ClientToken;
            context.Description = this.Description;
            context.Edition = this.Edition;
            context.Name = this.Name;
            #if MODULAR
            if (this.Name == null && ParameterWasBound(nameof(this.Name)))
            {
                WriteWarning("You are passing $null as a value for parameter Name which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.RoleArn = this.RoleArn;
            #if MODULAR
            if (this.RoleArn == null && ParameterWasBound(nameof(this.RoleArn)))
            {
                WriteWarning("You are passing $null as a value for parameter RoleArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.ServerSideEncryptionConfiguration_KmsKeyId = this.ServerSideEncryptionConfiguration_KmsKeyId;
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.Kendra.Model.Tag>(this.Tag);
            }
            context.UserContextPolicy = this.UserContextPolicy;
            if (this.UserTokenConfiguration != null)
            {
                context.UserTokenConfiguration = new List<Amazon.Kendra.Model.UserTokenConfiguration>(this.UserTokenConfiguration);
            }
            
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
            var request = new Amazon.Kendra.Model.CreateIndexRequest();
            
            if (cmdletContext.ClientToken != null)
            {
                request.ClientToken = cmdletContext.ClientToken;
            }
            if (cmdletContext.Description != null)
            {
                request.Description = cmdletContext.Description;
            }
            if (cmdletContext.Edition != null)
            {
                request.Edition = cmdletContext.Edition;
            }
            if (cmdletContext.Name != null)
            {
                request.Name = cmdletContext.Name;
            }
            if (cmdletContext.RoleArn != null)
            {
                request.RoleArn = cmdletContext.RoleArn;
            }
            
             // populate ServerSideEncryptionConfiguration
            var requestServerSideEncryptionConfigurationIsNull = true;
            request.ServerSideEncryptionConfiguration = new Amazon.Kendra.Model.ServerSideEncryptionConfiguration();
            System.String requestServerSideEncryptionConfiguration_serverSideEncryptionConfiguration_KmsKeyId = null;
            if (cmdletContext.ServerSideEncryptionConfiguration_KmsKeyId != null)
            {
                requestServerSideEncryptionConfiguration_serverSideEncryptionConfiguration_KmsKeyId = cmdletContext.ServerSideEncryptionConfiguration_KmsKeyId;
            }
            if (requestServerSideEncryptionConfiguration_serverSideEncryptionConfiguration_KmsKeyId != null)
            {
                request.ServerSideEncryptionConfiguration.KmsKeyId = requestServerSideEncryptionConfiguration_serverSideEncryptionConfiguration_KmsKeyId;
                requestServerSideEncryptionConfigurationIsNull = false;
            }
             // determine if request.ServerSideEncryptionConfiguration should be set to null
            if (requestServerSideEncryptionConfigurationIsNull)
            {
                request.ServerSideEncryptionConfiguration = null;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            if (cmdletContext.UserContextPolicy != null)
            {
                request.UserContextPolicy = cmdletContext.UserContextPolicy;
            }
            if (cmdletContext.UserTokenConfiguration != null)
            {
                request.UserTokenConfigurations = cmdletContext.UserTokenConfiguration;
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
        
        private Amazon.Kendra.Model.CreateIndexResponse CallAWSServiceOperation(IAmazonKendra client, Amazon.Kendra.Model.CreateIndexRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Kendra", "CreateIndex");
            try
            {
                #if DESKTOP
                return client.CreateIndex(request);
                #elif CORECLR
                return client.CreateIndexAsync(request).GetAwaiter().GetResult();
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
            public System.String ClientToken { get; set; }
            public System.String Description { get; set; }
            public Amazon.Kendra.IndexEdition Edition { get; set; }
            public System.String Name { get; set; }
            public System.String RoleArn { get; set; }
            public System.String ServerSideEncryptionConfiguration_KmsKeyId { get; set; }
            public List<Amazon.Kendra.Model.Tag> Tag { get; set; }
            public Amazon.Kendra.UserContextPolicy UserContextPolicy { get; set; }
            public List<Amazon.Kendra.Model.UserTokenConfiguration> UserTokenConfiguration { get; set; }
            public System.Func<Amazon.Kendra.Model.CreateIndexResponse, NewKNDRIndexCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Id;
        }
        
    }
}
