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
using Amazon.IoT;
using Amazon.IoT.Model;

namespace Amazon.PowerShell.Cmdlets.IOT
{
    /// <summary>
    /// Creates a job.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateJob</a>
    /// action.
    /// </para>
    /// </summary>
    [Cmdlet("New", "IOTJob", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.IoT.Model.CreateJobResponse")]
    [AWSCmdlet("Calls the AWS IoT CreateJob API operation.", Operation = new[] {"CreateJob"}, SelectReturnType = typeof(Amazon.IoT.Model.CreateJobResponse))]
    [AWSCmdletOutput("Amazon.IoT.Model.CreateJobResponse",
        "This cmdlet returns an Amazon.IoT.Model.CreateJobResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewIOTJobCmdlet : AmazonIoTClientCmdlet, IExecutor
    {
        
        #region Parameter AbortConfig_CriteriaList
        /// <summary>
        /// <para>
        /// <para>The list of criteria that determine when and how to abort the job.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.IoT.Model.AbortCriteria[] AbortConfig_CriteriaList { get; set; }
        #endregion
        
        #region Parameter Description
        /// <summary>
        /// <para>
        /// <para>A short text description of the job.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Description { get; set; }
        #endregion
        
        #region Parameter Document
        /// <summary>
        /// <para>
        /// <para>The job document. Required if you don't specify a value for <code>documentSource</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Document { get; set; }
        #endregion
        
        #region Parameter DocumentSource
        /// <summary>
        /// <para>
        /// <para>An S3 link to the job document. Required if you don't specify a value for <code>document</code>.</para><note><para>If the job document resides in an S3 bucket, you must use a placeholder link when
        /// specifying the document.</para><para>The placeholder link is of the following form:</para><para><code>${aws:iot:s3-presigned-url:https://s3.amazonaws.com/<i>bucket</i>/<i>key</i>}</code></para><para>where <i>bucket</i> is your bucket name and <i>key</i> is the object in the bucket
        /// to which you are linking.</para></note>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String DocumentSource { get; set; }
        #endregion
        
        #region Parameter PresignedUrlConfig_ExpiresInSec
        /// <summary>
        /// <para>
        /// <para>How long (in seconds) pre-signed URLs are valid. Valid values are 60 - 3600, the default
        /// value is 3600 seconds. Pre-signed URLs are generated when Jobs receives an MQTT request
        /// for the job document.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int64? PresignedUrlConfig_ExpiresInSec { get; set; }
        #endregion
        
        #region Parameter JobExecutionsRolloutConfig_ExponentialRate
        /// <summary>
        /// <para>
        /// <para>The rate of increase for a job rollout. This parameter allows you to define an exponential
        /// rate for a job rollout.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.IoT.Model.ExponentialRolloutRate JobExecutionsRolloutConfig_ExponentialRate { get; set; }
        #endregion
        
        #region Parameter TimeoutConfig_InProgressTimeoutInMinute
        /// <summary>
        /// <para>
        /// <para>Specifies the amount of time, in minutes, this device has to finish execution of this
        /// job. The timeout interval can be anywhere between 1 minute and 7 days (1 to 10080
        /// minutes). The in progress timer can't be updated and will apply to all job executions
        /// for the job. Whenever a job execution remains in the IN_PROGRESS status for longer
        /// than this interval, the job execution will fail and switch to the terminal <code>TIMED_OUT</code>
        /// status.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TimeoutConfig_InProgressTimeoutInMinutes")]
        public System.Int64? TimeoutConfig_InProgressTimeoutInMinute { get; set; }
        #endregion
        
        #region Parameter JobId
        /// <summary>
        /// <para>
        /// <para>A job identifier which must be unique for your Amazon Web Services account. We recommend
        /// using a UUID. Alpha-numeric characters, "-" and "_" are valid for use here.</para>
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
        public System.String JobId { get; set; }
        #endregion
        
        #region Parameter JobTemplateArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the job template used to create the job.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String JobTemplateArn { get; set; }
        #endregion
        
        #region Parameter JobExecutionsRolloutConfig_MaximumPerMinute
        /// <summary>
        /// <para>
        /// <para>The maximum number of things that will be notified of a pending job, per minute. This
        /// parameter allows you to create a staged rollout.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? JobExecutionsRolloutConfig_MaximumPerMinute { get; set; }
        #endregion
        
        #region Parameter NamespaceId
        /// <summary>
        /// <para>
        /// <para>The namespace used to indicate that a job is a customer-managed job.</para><para>When you specify a value for this parameter, Amazon Web Services IoT Core sends jobs
        /// notifications to MQTT topics that contain the value in the following format.</para><para><code>$aws/things/<i>THING_NAME</i>/jobs/<i>JOB_ID</i>/notify-namespace-<i>NAMESPACE_ID</i>/</code></para><note><para>The <code>namespaceId</code> feature is in public preview.</para></note>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NamespaceId { get; set; }
        #endregion
        
        #region Parameter PresignedUrlConfig_RoleArn
        /// <summary>
        /// <para>
        /// <para>The ARN of an IAM role that grants grants permission to download files from the S3
        /// bucket where the job data/updates are stored. The role must also grant permission
        /// for IoT to download the files.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String PresignedUrlConfig_RoleArn { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>Metadata which can be used to manage the job.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.IoT.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter Target
        /// <summary>
        /// <para>
        /// <para>A list of things and thing groups to which the job should be sent.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [Alias("Targets")]
        public System.String[] Target { get; set; }
        #endregion
        
        #region Parameter TargetSelection
        /// <summary>
        /// <para>
        /// <para>Specifies whether the job will continue to run (CONTINUOUS), or will be complete after
        /// all those things specified as targets have completed the job (SNAPSHOT). If continuous,
        /// the job may also be run on a thing when a change is detected in a target. For example,
        /// a job will run on a thing when the thing is added to a target group, even after the
        /// job was completed by all things originally in the group.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.IoT.TargetSelection")]
        public Amazon.IoT.TargetSelection TargetSelection { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.IoT.Model.CreateJobResponse).
        /// Specifying the name of a property of type Amazon.IoT.Model.CreateJobResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the JobId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^JobId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^JobId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.JobId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-IOTJob (CreateJob)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.IoT.Model.CreateJobResponse, NewIOTJobCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.JobId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (this.AbortConfig_CriteriaList != null)
            {
                context.AbortConfig_CriteriaList = new List<Amazon.IoT.Model.AbortCriteria>(this.AbortConfig_CriteriaList);
            }
            context.Description = this.Description;
            context.Document = this.Document;
            context.DocumentSource = this.DocumentSource;
            context.JobExecutionsRolloutConfig_ExponentialRate = this.JobExecutionsRolloutConfig_ExponentialRate;
            context.JobExecutionsRolloutConfig_MaximumPerMinute = this.JobExecutionsRolloutConfig_MaximumPerMinute;
            context.JobId = this.JobId;
            #if MODULAR
            if (this.JobId == null && ParameterWasBound(nameof(this.JobId)))
            {
                WriteWarning("You are passing $null as a value for parameter JobId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.JobTemplateArn = this.JobTemplateArn;
            context.NamespaceId = this.NamespaceId;
            context.PresignedUrlConfig_ExpiresInSec = this.PresignedUrlConfig_ExpiresInSec;
            context.PresignedUrlConfig_RoleArn = this.PresignedUrlConfig_RoleArn;
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.IoT.Model.Tag>(this.Tag);
            }
            if (this.Target != null)
            {
                context.Target = new List<System.String>(this.Target);
            }
            #if MODULAR
            if (this.Target == null && ParameterWasBound(nameof(this.Target)))
            {
                WriteWarning("You are passing $null as a value for parameter Target which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.TargetSelection = this.TargetSelection;
            context.TimeoutConfig_InProgressTimeoutInMinute = this.TimeoutConfig_InProgressTimeoutInMinute;
            
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
            var request = new Amazon.IoT.Model.CreateJobRequest();
            
            
             // populate AbortConfig
            var requestAbortConfigIsNull = true;
            request.AbortConfig = new Amazon.IoT.Model.AbortConfig();
            List<Amazon.IoT.Model.AbortCriteria> requestAbortConfig_abortConfig_CriteriaList = null;
            if (cmdletContext.AbortConfig_CriteriaList != null)
            {
                requestAbortConfig_abortConfig_CriteriaList = cmdletContext.AbortConfig_CriteriaList;
            }
            if (requestAbortConfig_abortConfig_CriteriaList != null)
            {
                request.AbortConfig.CriteriaList = requestAbortConfig_abortConfig_CriteriaList;
                requestAbortConfigIsNull = false;
            }
             // determine if request.AbortConfig should be set to null
            if (requestAbortConfigIsNull)
            {
                request.AbortConfig = null;
            }
            if (cmdletContext.Description != null)
            {
                request.Description = cmdletContext.Description;
            }
            if (cmdletContext.Document != null)
            {
                request.Document = cmdletContext.Document;
            }
            if (cmdletContext.DocumentSource != null)
            {
                request.DocumentSource = cmdletContext.DocumentSource;
            }
            
             // populate JobExecutionsRolloutConfig
            var requestJobExecutionsRolloutConfigIsNull = true;
            request.JobExecutionsRolloutConfig = new Amazon.IoT.Model.JobExecutionsRolloutConfig();
            Amazon.IoT.Model.ExponentialRolloutRate requestJobExecutionsRolloutConfig_jobExecutionsRolloutConfig_ExponentialRate = null;
            if (cmdletContext.JobExecutionsRolloutConfig_ExponentialRate != null)
            {
                requestJobExecutionsRolloutConfig_jobExecutionsRolloutConfig_ExponentialRate = cmdletContext.JobExecutionsRolloutConfig_ExponentialRate;
            }
            if (requestJobExecutionsRolloutConfig_jobExecutionsRolloutConfig_ExponentialRate != null)
            {
                request.JobExecutionsRolloutConfig.ExponentialRate = requestJobExecutionsRolloutConfig_jobExecutionsRolloutConfig_ExponentialRate;
                requestJobExecutionsRolloutConfigIsNull = false;
            }
            System.Int32? requestJobExecutionsRolloutConfig_jobExecutionsRolloutConfig_MaximumPerMinute = null;
            if (cmdletContext.JobExecutionsRolloutConfig_MaximumPerMinute != null)
            {
                requestJobExecutionsRolloutConfig_jobExecutionsRolloutConfig_MaximumPerMinute = cmdletContext.JobExecutionsRolloutConfig_MaximumPerMinute.Value;
            }
            if (requestJobExecutionsRolloutConfig_jobExecutionsRolloutConfig_MaximumPerMinute != null)
            {
                request.JobExecutionsRolloutConfig.MaximumPerMinute = requestJobExecutionsRolloutConfig_jobExecutionsRolloutConfig_MaximumPerMinute.Value;
                requestJobExecutionsRolloutConfigIsNull = false;
            }
             // determine if request.JobExecutionsRolloutConfig should be set to null
            if (requestJobExecutionsRolloutConfigIsNull)
            {
                request.JobExecutionsRolloutConfig = null;
            }
            if (cmdletContext.JobId != null)
            {
                request.JobId = cmdletContext.JobId;
            }
            if (cmdletContext.JobTemplateArn != null)
            {
                request.JobTemplateArn = cmdletContext.JobTemplateArn;
            }
            if (cmdletContext.NamespaceId != null)
            {
                request.NamespaceId = cmdletContext.NamespaceId;
            }
            
             // populate PresignedUrlConfig
            var requestPresignedUrlConfigIsNull = true;
            request.PresignedUrlConfig = new Amazon.IoT.Model.PresignedUrlConfig();
            System.Int64? requestPresignedUrlConfig_presignedUrlConfig_ExpiresInSec = null;
            if (cmdletContext.PresignedUrlConfig_ExpiresInSec != null)
            {
                requestPresignedUrlConfig_presignedUrlConfig_ExpiresInSec = cmdletContext.PresignedUrlConfig_ExpiresInSec.Value;
            }
            if (requestPresignedUrlConfig_presignedUrlConfig_ExpiresInSec != null)
            {
                request.PresignedUrlConfig.ExpiresInSec = requestPresignedUrlConfig_presignedUrlConfig_ExpiresInSec.Value;
                requestPresignedUrlConfigIsNull = false;
            }
            System.String requestPresignedUrlConfig_presignedUrlConfig_RoleArn = null;
            if (cmdletContext.PresignedUrlConfig_RoleArn != null)
            {
                requestPresignedUrlConfig_presignedUrlConfig_RoleArn = cmdletContext.PresignedUrlConfig_RoleArn;
            }
            if (requestPresignedUrlConfig_presignedUrlConfig_RoleArn != null)
            {
                request.PresignedUrlConfig.RoleArn = requestPresignedUrlConfig_presignedUrlConfig_RoleArn;
                requestPresignedUrlConfigIsNull = false;
            }
             // determine if request.PresignedUrlConfig should be set to null
            if (requestPresignedUrlConfigIsNull)
            {
                request.PresignedUrlConfig = null;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            if (cmdletContext.Target != null)
            {
                request.Targets = cmdletContext.Target;
            }
            if (cmdletContext.TargetSelection != null)
            {
                request.TargetSelection = cmdletContext.TargetSelection;
            }
            
             // populate TimeoutConfig
            var requestTimeoutConfigIsNull = true;
            request.TimeoutConfig = new Amazon.IoT.Model.TimeoutConfig();
            System.Int64? requestTimeoutConfig_timeoutConfig_InProgressTimeoutInMinute = null;
            if (cmdletContext.TimeoutConfig_InProgressTimeoutInMinute != null)
            {
                requestTimeoutConfig_timeoutConfig_InProgressTimeoutInMinute = cmdletContext.TimeoutConfig_InProgressTimeoutInMinute.Value;
            }
            if (requestTimeoutConfig_timeoutConfig_InProgressTimeoutInMinute != null)
            {
                request.TimeoutConfig.InProgressTimeoutInMinutes = requestTimeoutConfig_timeoutConfig_InProgressTimeoutInMinute.Value;
                requestTimeoutConfigIsNull = false;
            }
             // determine if request.TimeoutConfig should be set to null
            if (requestTimeoutConfigIsNull)
            {
                request.TimeoutConfig = null;
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
        
        private Amazon.IoT.Model.CreateJobResponse CallAWSServiceOperation(IAmazonIoT client, Amazon.IoT.Model.CreateJobRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS IoT", "CreateJob");
            try
            {
                #if DESKTOP
                return client.CreateJob(request);
                #elif CORECLR
                return client.CreateJobAsync(request).GetAwaiter().GetResult();
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
            public List<Amazon.IoT.Model.AbortCriteria> AbortConfig_CriteriaList { get; set; }
            public System.String Description { get; set; }
            public System.String Document { get; set; }
            public System.String DocumentSource { get; set; }
            public Amazon.IoT.Model.ExponentialRolloutRate JobExecutionsRolloutConfig_ExponentialRate { get; set; }
            public System.Int32? JobExecutionsRolloutConfig_MaximumPerMinute { get; set; }
            public System.String JobId { get; set; }
            public System.String JobTemplateArn { get; set; }
            public System.String NamespaceId { get; set; }
            public System.Int64? PresignedUrlConfig_ExpiresInSec { get; set; }
            public System.String PresignedUrlConfig_RoleArn { get; set; }
            public List<Amazon.IoT.Model.Tag> Tag { get; set; }
            public List<System.String> Target { get; set; }
            public Amazon.IoT.TargetSelection TargetSelection { get; set; }
            public System.Int64? TimeoutConfig_InProgressTimeoutInMinute { get; set; }
            public System.Func<Amazon.IoT.Model.CreateJobResponse, NewIOTJobCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
