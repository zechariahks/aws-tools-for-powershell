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
using Amazon.RDS;
using Amazon.RDS.Model;

namespace Amazon.PowerShell.Cmdlets.RDS
{
    /// <summary>
    /// Set the capacity of an Aurora Serverless DB cluster to a specific value.
    /// 
    ///  
    /// <para>
    /// Aurora Serverless scales seamlessly based on the workload on the DB cluster. In some
    /// cases, the capacity might not scale fast enough to meet a sudden change in workload,
    /// such as a large number of new transactions. Call <code>ModifyCurrentDBClusterCapacity</code>
    /// to set the capacity explicitly.
    /// </para><para>
    /// After this call sets the DB cluster capacity, Aurora Serverless can automatically
    /// scale the DB cluster based on the cooldown period for scaling up and the cooldown
    /// period for scaling down.
    /// </para><para>
    /// For more information about Aurora Serverless, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless.html">Using
    /// Amazon Aurora Serverless</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para><important><para>
    /// If you call <code>ModifyCurrentDBClusterCapacity</code> with the default <code>TimeoutAction</code>,
    /// connections that prevent Aurora Serverless from finding a scaling point might be dropped.
    /// For more information about scaling points, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless.how-it-works.html#aurora-serverless.how-it-works.auto-scaling">
    /// Autoscaling for Aurora Serverless</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para></important><note><para>
    /// This action only applies to Aurora DB clusters.
    /// </para></note>
    /// </summary>
    [Cmdlet("Edit", "RDSCurrentDBClusterCapacity", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.RDS.Model.ModifyCurrentDBClusterCapacityResponse")]
    [AWSCmdlet("Calls the Amazon Relational Database Service ModifyCurrentDBClusterCapacity API operation.", Operation = new[] {"ModifyCurrentDBClusterCapacity"}, SelectReturnType = typeof(Amazon.RDS.Model.ModifyCurrentDBClusterCapacityResponse))]
    [AWSCmdletOutput("Amazon.RDS.Model.ModifyCurrentDBClusterCapacityResponse",
        "This cmdlet returns an Amazon.RDS.Model.ModifyCurrentDBClusterCapacityResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class EditRDSCurrentDBClusterCapacityCmdlet : AmazonRDSClientCmdlet, IExecutor
    {
        
        #region Parameter Capacity
        /// <summary>
        /// <para>
        /// <para>The DB cluster capacity.</para><para>When you change the capacity of a paused Aurora Serverless DB cluster, it automatically
        /// resumes.</para><para>Constraints:</para><ul><li><para>For Aurora MySQL, valid capacity values are <code>1</code>, <code>2</code>, <code>4</code>,
        /// <code>8</code>, <code>16</code>, <code>32</code>, <code>64</code>, <code>128</code>,
        /// and <code>256</code>.</para></li><li><para>For Aurora PostgreSQL, valid capacity values are <code>2</code>, <code>4</code>, <code>8</code>,
        /// <code>16</code>, <code>32</code>, <code>64</code>, <code>192</code>, and <code>384</code>.</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? Capacity { get; set; }
        #endregion
        
        #region Parameter DBClusterIdentifier
        /// <summary>
        /// <para>
        /// <para>The DB cluster identifier for the cluster being modified. This parameter isn't case-sensitive.</para><para>Constraints:</para><ul><li><para>Must match the identifier of an existing DB cluster.</para></li></ul>
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
        public System.String DBClusterIdentifier { get; set; }
        #endregion
        
        #region Parameter SecondsBeforeTimeout
        /// <summary>
        /// <para>
        /// <para>The amount of time, in seconds, that Aurora Serverless tries to find a scaling point
        /// to perform seamless scaling before enforcing the timeout action. The default is 300.</para><ul><li><para>Value must be from 10 through 600.</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? SecondsBeforeTimeout { get; set; }
        #endregion
        
        #region Parameter TimeoutAction
        /// <summary>
        /// <para>
        /// <para>The action to take when the timeout is reached, either <code>ForceApplyCapacityChange</code>
        /// or <code>RollbackCapacityChange</code>.</para><para><code>ForceApplyCapacityChange</code>, the default, sets the capacity to the specified
        /// value as soon as possible.</para><para><code>RollbackCapacityChange</code> ignores the capacity change if a scaling point
        /// isn't found in the timeout period.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String TimeoutAction { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.RDS.Model.ModifyCurrentDBClusterCapacityResponse).
        /// Specifying the name of a property of type Amazon.RDS.Model.ModifyCurrentDBClusterCapacityResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the DBClusterIdentifier parameter.
        /// The -PassThru parameter is deprecated, use -Select '^DBClusterIdentifier' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^DBClusterIdentifier' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.DBClusterIdentifier), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Edit-RDSCurrentDBClusterCapacity (ModifyCurrentDBClusterCapacity)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.RDS.Model.ModifyCurrentDBClusterCapacityResponse, EditRDSCurrentDBClusterCapacityCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.DBClusterIdentifier;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.Capacity = this.Capacity;
            context.DBClusterIdentifier = this.DBClusterIdentifier;
            #if MODULAR
            if (this.DBClusterIdentifier == null && ParameterWasBound(nameof(this.DBClusterIdentifier)))
            {
                WriteWarning("You are passing $null as a value for parameter DBClusterIdentifier which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.SecondsBeforeTimeout = this.SecondsBeforeTimeout;
            context.TimeoutAction = this.TimeoutAction;
            
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
            var request = new Amazon.RDS.Model.ModifyCurrentDBClusterCapacityRequest();
            
            if (cmdletContext.Capacity != null)
            {
                request.Capacity = cmdletContext.Capacity.Value;
            }
            if (cmdletContext.DBClusterIdentifier != null)
            {
                request.DBClusterIdentifier = cmdletContext.DBClusterIdentifier;
            }
            if (cmdletContext.SecondsBeforeTimeout != null)
            {
                request.SecondsBeforeTimeout = cmdletContext.SecondsBeforeTimeout.Value;
            }
            if (cmdletContext.TimeoutAction != null)
            {
                request.TimeoutAction = cmdletContext.TimeoutAction;
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
        
        private Amazon.RDS.Model.ModifyCurrentDBClusterCapacityResponse CallAWSServiceOperation(IAmazonRDS client, Amazon.RDS.Model.ModifyCurrentDBClusterCapacityRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Relational Database Service", "ModifyCurrentDBClusterCapacity");
            try
            {
                #if DESKTOP
                return client.ModifyCurrentDBClusterCapacity(request);
                #elif CORECLR
                return client.ModifyCurrentDBClusterCapacityAsync(request).GetAwaiter().GetResult();
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
            public System.Int32? Capacity { get; set; }
            public System.String DBClusterIdentifier { get; set; }
            public System.Int32? SecondsBeforeTimeout { get; set; }
            public System.String TimeoutAction { get; set; }
            public System.Func<Amazon.RDS.Model.ModifyCurrentDBClusterCapacityResponse, EditRDSCurrentDBClusterCapacityCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
