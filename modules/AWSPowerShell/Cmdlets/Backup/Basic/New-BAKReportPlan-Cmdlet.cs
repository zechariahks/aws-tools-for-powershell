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
using Amazon.Backup;
using Amazon.Backup.Model;

namespace Amazon.PowerShell.Cmdlets.BAK
{
    /// <summary>
    /// Creates a report plan. A report plan is a document that contains information about
    /// the contents of the report and where Backup will deliver it.
    /// 
    ///  
    /// <para>
    /// If you call <code>CreateReportPlan</code> with a plan that already exists, you receive
    /// an <code>AlreadyExistsException</code> exception.
    /// </para>
    /// </summary>
    [Cmdlet("New", "BAKReportPlan", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.Backup.Model.CreateReportPlanResponse")]
    [AWSCmdlet("Calls the AWS Backup CreateReportPlan API operation.", Operation = new[] {"CreateReportPlan"}, SelectReturnType = typeof(Amazon.Backup.Model.CreateReportPlanResponse))]
    [AWSCmdletOutput("Amazon.Backup.Model.CreateReportPlanResponse",
        "This cmdlet returns an Amazon.Backup.Model.CreateReportPlanResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewBAKReportPlanCmdlet : AmazonBackupClientCmdlet, IExecutor
    {
        
        #region Parameter ReportDeliveryChannel_Format
        /// <summary>
        /// <para>
        /// <para>A list of the format of your reports: <code>CSV</code>, <code>JSON</code>, or both.
        /// If not specified, the default format is <code>CSV</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ReportDeliveryChannel_Formats")]
        public System.String[] ReportDeliveryChannel_Format { get; set; }
        #endregion
        
        #region Parameter IdempotencyToken
        /// <summary>
        /// <para>
        /// <para>A customer-chosen string that you can use to distinguish between otherwise identical
        /// calls to <code>CreateReportPlanInput</code>. Retrying a successful request with the
        /// same idempotency token results in a success message with no action taken.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String IdempotencyToken { get; set; }
        #endregion
        
        #region Parameter ReportPlanDescription
        /// <summary>
        /// <para>
        /// <para>An optional description of the report plan with a maximum of 1,024 characters.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ReportPlanDescription { get; set; }
        #endregion
        
        #region Parameter ReportPlanName
        /// <summary>
        /// <para>
        /// <para>The unique name of the report plan. The name must be between 1 and 256 characters,
        /// starting with a letter, and consisting of letters (a-z, A-Z), numbers (0-9), and underscores
        /// (_).</para>
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
        public System.String ReportPlanName { get; set; }
        #endregion
        
        #region Parameter ReportPlanTag
        /// <summary>
        /// <para>
        /// <para>Metadata that you can assign to help organize the frameworks that you create. Each
        /// tag is a key-value pair.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ReportPlanTags")]
        public System.Collections.Hashtable ReportPlanTag { get; set; }
        #endregion
        
        #region Parameter ReportSetting_ReportTemplate
        /// <summary>
        /// <para>
        /// <para>Identifies the report template for the report. Reports are built using a report template.
        /// The report templates are:</para><para><code>BACKUP_JOB_REPORT | COPY_JOB_REPORT | RESTORE_JOB_REPORT</code></para>
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
        public System.String ReportSetting_ReportTemplate { get; set; }
        #endregion
        
        #region Parameter ReportDeliveryChannel_S3BucketName
        /// <summary>
        /// <para>
        /// <para>The unique name of the S3 bucket that receives your reports.</para>
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
        public System.String ReportDeliveryChannel_S3BucketName { get; set; }
        #endregion
        
        #region Parameter ReportDeliveryChannel_S3KeyPrefix
        /// <summary>
        /// <para>
        /// <para>The prefix for where Backup Audit Manager delivers your reports to Amazon S3. The
        /// prefix is this part of the following path: s3://your-bucket-name/<code>prefix</code>/Backup/us-west-2/year/month/day/report-name.
        /// If not specified, there is no prefix.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ReportDeliveryChannel_S3KeyPrefix { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Backup.Model.CreateReportPlanResponse).
        /// Specifying the name of a property of type Amazon.Backup.Model.CreateReportPlanResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the ReportPlanName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^ReportPlanName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^ReportPlanName' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.ReportPlanName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-BAKReportPlan (CreateReportPlan)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Backup.Model.CreateReportPlanResponse, NewBAKReportPlanCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.ReportPlanName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.IdempotencyToken = this.IdempotencyToken;
            if (this.ReportDeliveryChannel_Format != null)
            {
                context.ReportDeliveryChannel_Format = new List<System.String>(this.ReportDeliveryChannel_Format);
            }
            context.ReportDeliveryChannel_S3BucketName = this.ReportDeliveryChannel_S3BucketName;
            #if MODULAR
            if (this.ReportDeliveryChannel_S3BucketName == null && ParameterWasBound(nameof(this.ReportDeliveryChannel_S3BucketName)))
            {
                WriteWarning("You are passing $null as a value for parameter ReportDeliveryChannel_S3BucketName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.ReportDeliveryChannel_S3KeyPrefix = this.ReportDeliveryChannel_S3KeyPrefix;
            context.ReportPlanDescription = this.ReportPlanDescription;
            context.ReportPlanName = this.ReportPlanName;
            #if MODULAR
            if (this.ReportPlanName == null && ParameterWasBound(nameof(this.ReportPlanName)))
            {
                WriteWarning("You are passing $null as a value for parameter ReportPlanName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.ReportPlanTag != null)
            {
                context.ReportPlanTag = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.ReportPlanTag.Keys)
                {
                    context.ReportPlanTag.Add((String)hashKey, (String)(this.ReportPlanTag[hashKey]));
                }
            }
            context.ReportSetting_ReportTemplate = this.ReportSetting_ReportTemplate;
            #if MODULAR
            if (this.ReportSetting_ReportTemplate == null && ParameterWasBound(nameof(this.ReportSetting_ReportTemplate)))
            {
                WriteWarning("You are passing $null as a value for parameter ReportSetting_ReportTemplate which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            
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
            var request = new Amazon.Backup.Model.CreateReportPlanRequest();
            
            if (cmdletContext.IdempotencyToken != null)
            {
                request.IdempotencyToken = cmdletContext.IdempotencyToken;
            }
            
             // populate ReportDeliveryChannel
            var requestReportDeliveryChannelIsNull = true;
            request.ReportDeliveryChannel = new Amazon.Backup.Model.ReportDeliveryChannel();
            List<System.String> requestReportDeliveryChannel_reportDeliveryChannel_Format = null;
            if (cmdletContext.ReportDeliveryChannel_Format != null)
            {
                requestReportDeliveryChannel_reportDeliveryChannel_Format = cmdletContext.ReportDeliveryChannel_Format;
            }
            if (requestReportDeliveryChannel_reportDeliveryChannel_Format != null)
            {
                request.ReportDeliveryChannel.Formats = requestReportDeliveryChannel_reportDeliveryChannel_Format;
                requestReportDeliveryChannelIsNull = false;
            }
            System.String requestReportDeliveryChannel_reportDeliveryChannel_S3BucketName = null;
            if (cmdletContext.ReportDeliveryChannel_S3BucketName != null)
            {
                requestReportDeliveryChannel_reportDeliveryChannel_S3BucketName = cmdletContext.ReportDeliveryChannel_S3BucketName;
            }
            if (requestReportDeliveryChannel_reportDeliveryChannel_S3BucketName != null)
            {
                request.ReportDeliveryChannel.S3BucketName = requestReportDeliveryChannel_reportDeliveryChannel_S3BucketName;
                requestReportDeliveryChannelIsNull = false;
            }
            System.String requestReportDeliveryChannel_reportDeliveryChannel_S3KeyPrefix = null;
            if (cmdletContext.ReportDeliveryChannel_S3KeyPrefix != null)
            {
                requestReportDeliveryChannel_reportDeliveryChannel_S3KeyPrefix = cmdletContext.ReportDeliveryChannel_S3KeyPrefix;
            }
            if (requestReportDeliveryChannel_reportDeliveryChannel_S3KeyPrefix != null)
            {
                request.ReportDeliveryChannel.S3KeyPrefix = requestReportDeliveryChannel_reportDeliveryChannel_S3KeyPrefix;
                requestReportDeliveryChannelIsNull = false;
            }
             // determine if request.ReportDeliveryChannel should be set to null
            if (requestReportDeliveryChannelIsNull)
            {
                request.ReportDeliveryChannel = null;
            }
            if (cmdletContext.ReportPlanDescription != null)
            {
                request.ReportPlanDescription = cmdletContext.ReportPlanDescription;
            }
            if (cmdletContext.ReportPlanName != null)
            {
                request.ReportPlanName = cmdletContext.ReportPlanName;
            }
            if (cmdletContext.ReportPlanTag != null)
            {
                request.ReportPlanTags = cmdletContext.ReportPlanTag;
            }
            
             // populate ReportSetting
            var requestReportSettingIsNull = true;
            request.ReportSetting = new Amazon.Backup.Model.ReportSetting();
            System.String requestReportSetting_reportSetting_ReportTemplate = null;
            if (cmdletContext.ReportSetting_ReportTemplate != null)
            {
                requestReportSetting_reportSetting_ReportTemplate = cmdletContext.ReportSetting_ReportTemplate;
            }
            if (requestReportSetting_reportSetting_ReportTemplate != null)
            {
                request.ReportSetting.ReportTemplate = requestReportSetting_reportSetting_ReportTemplate;
                requestReportSettingIsNull = false;
            }
             // determine if request.ReportSetting should be set to null
            if (requestReportSettingIsNull)
            {
                request.ReportSetting = null;
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
        
        private Amazon.Backup.Model.CreateReportPlanResponse CallAWSServiceOperation(IAmazonBackup client, Amazon.Backup.Model.CreateReportPlanRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Backup", "CreateReportPlan");
            try
            {
                #if DESKTOP
                return client.CreateReportPlan(request);
                #elif CORECLR
                return client.CreateReportPlanAsync(request).GetAwaiter().GetResult();
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
            public System.String IdempotencyToken { get; set; }
            public List<System.String> ReportDeliveryChannel_Format { get; set; }
            public System.String ReportDeliveryChannel_S3BucketName { get; set; }
            public System.String ReportDeliveryChannel_S3KeyPrefix { get; set; }
            public System.String ReportPlanDescription { get; set; }
            public System.String ReportPlanName { get; set; }
            public Dictionary<System.String, System.String> ReportPlanTag { get; set; }
            public System.String ReportSetting_ReportTemplate { get; set; }
            public System.Func<Amazon.Backup.Model.CreateReportPlanResponse, NewBAKReportPlanCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
