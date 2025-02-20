# Auto-generated argument completers for parameters of SDK ConstantClass-derived type used in cmdlets.
# Do not modify this file; it may be overwritten during version upgrades.

$psMajorVersion = $PSVersionTable.PSVersion.Major
if ($psMajorVersion -eq 2) 
{ 
	Write-Verbose "Dynamic argument completion not supported in PowerShell version 2; skipping load."
	return 
}

# PowerShell's native Register-ArgumentCompleter cmdlet is available on v5.0 or higher. For lower
# version, we can use the version in the TabExpansion++ module if installed.
$registrationCmdletAvailable = ($psMajorVersion -ge 5) -Or !((Get-Command Register-ArgumentCompleter -ea Ignore) -eq $null)

# internal function to perform the registration using either cmdlet or manipulation
# of the options table
function _awsArgumentCompleterRegistration()
{
    param
    (
        [scriptblock]$scriptBlock,
        [hashtable]$param2CmdletsMap
    )

    if ($registrationCmdletAvailable)
    {
        foreach ($paramName in $param2CmdletsMap.Keys)
        {
             $args = @{
                "ScriptBlock" = $scriptBlock
                "Parameter" = $paramName
            }

            $cmdletNames = $param2CmdletsMap[$paramName]
            if ($cmdletNames -And $cmdletNames.Length -gt 0)
            {
                $args["Command"] = $cmdletNames
            }

            Register-ArgumentCompleter @args
        }
    }
    else
    {
        if (-not $global:options) { $global:options = @{ CustomArgumentCompleters = @{ }; NativeArgumentCompleters = @{ } } }

        foreach ($paramName in $param2CmdletsMap.Keys)
        {
            $cmdletNames = $param2CmdletsMap[$paramName]

            if ($cmdletNames -And $cmdletNames.Length -gt 0)
            {
                foreach ($cn in $cmdletNames)
                {
                    $fqn =  [string]::Concat($cn, ":", $paramName)
                    $global:options['CustomArgumentCompleters'][$fqn] = $scriptBlock
                }
            }
            else
            {
                $global:options['CustomArgumentCompleters'][$paramName] = $scriptBlock
            }
        }

        $function:tabexpansion2 = $function:tabexpansion2 -replace 'End\r\n{', 'End { if ($null -ne $options) { $options += $global:options} else {$options = $global:options}'
    }
}

# To allow for same-name parameters of different ConstantClass-derived types 
# each completer function checks on command name concatenated with parameter name.
# Additionally, the standard code pattern for completers is to pipe through 
# sort-object after filtering against $wordToComplete but we omit this as our members 
# are already sorted.

# Argument completions for service Amazon SageMaker Service


$SM_Completers = {
    param($commandName, $parameterName, $wordToComplete, $commandAst, $fakeBoundParameter)

    switch ($("$commandName/$parameterName"))
    {
        # Amazon.SageMaker.ActionStatus
        {
            ($_ -eq "New-SMAction/Status") -Or
            ($_ -eq "Update-SMAction/Status")
        }
        {
            $v = "Completed","Failed","InProgress","Stopped","Stopping","Unknown"
            break
        }

        # Amazon.SageMaker.AlgorithmSortBy
        "Get-SMAlgorithmList/SortBy"
        {
            $v = "CreationTime","Name"
            break
        }

        # Amazon.SageMaker.AppImageConfigSortKey
        "Get-SMAppImageConfigList/SortBy"
        {
            $v = "CreationTime","LastModifiedTime","Name"
            break
        }

        # Amazon.SageMaker.AppInstanceType
        "New-SMApp/ResourceSpec_InstanceType"
        {
            $v = "ml.c5.12xlarge","ml.c5.18xlarge","ml.c5.24xlarge","ml.c5.2xlarge","ml.c5.4xlarge","ml.c5.9xlarge","ml.c5.large","ml.c5.xlarge","ml.g4dn.12xlarge","ml.g4dn.16xlarge","ml.g4dn.2xlarge","ml.g4dn.4xlarge","ml.g4dn.8xlarge","ml.g4dn.xlarge","ml.m5.12xlarge","ml.m5.16xlarge","ml.m5.24xlarge","ml.m5.2xlarge","ml.m5.4xlarge","ml.m5.8xlarge","ml.m5.large","ml.m5.xlarge","ml.m5d.12xlarge","ml.m5d.16xlarge","ml.m5d.24xlarge","ml.m5d.2xlarge","ml.m5d.4xlarge","ml.m5d.8xlarge","ml.m5d.large","ml.m5d.xlarge","ml.p3.16xlarge","ml.p3.2xlarge","ml.p3.8xlarge","ml.p3dn.24xlarge","ml.r5.12xlarge","ml.r5.16xlarge","ml.r5.24xlarge","ml.r5.2xlarge","ml.r5.4xlarge","ml.r5.8xlarge","ml.r5.large","ml.r5.xlarge","ml.t3.2xlarge","ml.t3.large","ml.t3.medium","ml.t3.micro","ml.t3.small","ml.t3.xlarge","system"
            break
        }

        # Amazon.SageMaker.AppNetworkAccessType
        "New-SMDomain/AppNetworkAccessType"
        {
            $v = "PublicInternetOnly","VpcOnly"
            break
        }

        # Amazon.SageMaker.AppSortKey
        "Get-SMAppList/SortBy"
        {
            $v = "CreationTime"
            break
        }

        # Amazon.SageMaker.AppType
        {
            ($_ -eq "Get-SMApp/AppType") -Or
            ($_ -eq "New-SMApp/AppType") -Or
            ($_ -eq "Remove-SMApp/AppType")
        }
        {
            $v = "JupyterServer","KernelGateway","TensorBoard"
            break
        }

        # Amazon.SageMaker.AssemblyType
        "New-SMTransformJob/TransformOutput_AssembleWith"
        {
            $v = "Line","None"
            break
        }

        # Amazon.SageMaker.AssociationEdgeType
        {
            ($_ -eq "Add-SMAssociation/AssociationType") -Or
            ($_ -eq "Get-SMAssociationList/AssociationType")
        }
        {
            $v = "AssociatedWith","ContributedTo","DerivedFrom","Produced"
            break
        }

        # Amazon.SageMaker.AuthMode
        "New-SMDomain/AuthMode"
        {
            $v = "IAM","SSO"
            break
        }

        # Amazon.SageMaker.AutoMLJobStatus
        "Get-SMAutoMLJobList/StatusEquals"
        {
            $v = "Completed","Failed","InProgress","Stopped","Stopping"
            break
        }

        # Amazon.SageMaker.AutoMLMetricEnum
        "New-SMAutoMLJob/AutoMLJobObjective_MetricName"
        {
            $v = "Accuracy","AUC","F1","F1macro","MSE"
            break
        }

        # Amazon.SageMaker.AutoMLSortBy
        "Get-SMAutoMLJobList/SortBy"
        {
            $v = "CreationTime","Name","Status"
            break
        }

        # Amazon.SageMaker.AutoMLSortOrder
        {
            ($_ -eq "Get-SMAutoMLJobList/SortOrder") -Or
            ($_ -eq "Get-SMCandidatesForAutoMLJobList/SortOrder")
        }
        {
            $v = "Ascending","Descending"
            break
        }

        # Amazon.SageMaker.AwsManagedHumanLoopRequestSource
        "New-SMFlowDefinition/HumanLoopRequestSource_AwsManagedHumanLoopRequestSource"
        {
            $v = "AWS/Rekognition/DetectModerationLabels/Image/V3","AWS/Textract/AnalyzeDocument/Forms/V1"
            break
        }

        # Amazon.SageMaker.BatchStrategy
        "New-SMTransformJob/BatchStrategy"
        {
            $v = "MultiRecord","SingleRecord"
            break
        }

        # Amazon.SageMaker.BooleanOperator
        "Search-SMResource/SearchExpression_Operator"
        {
            $v = "And","Or"
            break
        }

        # Amazon.SageMaker.CandidateSortBy
        "Get-SMCandidatesForAutoMLJobList/SortBy"
        {
            $v = "CreationTime","FinalObjectiveMetricValue","Status"
            break
        }

        # Amazon.SageMaker.CandidateStatus
        "Get-SMCandidatesForAutoMLJobList/StatusEquals"
        {
            $v = "Completed","Failed","InProgress","Stopped","Stopping"
            break
        }

        # Amazon.SageMaker.CapacitySizeType
        "Update-SMEndpoint/DeploymentConfig_BlueGreenUpdatePolicy_TrafficRoutingConfiguration_CanarySize_Type"
        {
            $v = "CAPACITY_PERCENT","INSTANCE_COUNT"
            break
        }

        # Amazon.SageMaker.CodeRepositorySortBy
        "Get-SMCodeRepositoryList/SortBy"
        {
            $v = "CreationTime","LastModifiedTime","Name"
            break
        }

        # Amazon.SageMaker.CodeRepositorySortOrder
        "Get-SMCodeRepositoryList/SortOrder"
        {
            $v = "Ascending","Descending"
            break
        }

        # Amazon.SageMaker.CompilationJobStatus
        "Get-SMCompilationJobList/StatusEquals"
        {
            $v = "COMPLETED","FAILED","INPROGRESS","STARTING","STOPPED","STOPPING"
            break
        }

        # Amazon.SageMaker.CompressionType
        "New-SMTransformJob/TransformInput_CompressionType"
        {
            $v = "Gzip","None"
            break
        }

        # Amazon.SageMaker.DirectInternetAccess
        "New-SMNotebookInstance/DirectInternetAccess"
        {
            $v = "Disabled","Enabled"
            break
        }

        # Amazon.SageMaker.EdgePackagingJobStatus
        "Get-SMEdgePackagingJobList/StatusEquals"
        {
            $v = "COMPLETED","FAILED","INPROGRESS","STARTING","STOPPED","STOPPING"
            break
        }

        # Amazon.SageMaker.EdgePresetDeploymentType
        {
            ($_ -eq "New-SMDeviceFleet/OutputConfig_PresetDeploymentType") -Or
            ($_ -eq "New-SMEdgePackagingJob/OutputConfig_PresetDeploymentType") -Or
            ($_ -eq "Update-SMDeviceFleet/OutputConfig_PresetDeploymentType")
        }
        {
            $v = "GreengrassV2Component"
            break
        }

        # Amazon.SageMaker.EndpointConfigSortKey
        "Get-SMConfigList/SortBy"
        {
            $v = "CreationTime","Name"
            break
        }

        # Amazon.SageMaker.EndpointSortKey
        "Get-SMEndpointList/SortBy"
        {
            $v = "CreationTime","Name","Status"
            break
        }

        # Amazon.SageMaker.EndpointStatus
        "Get-SMEndpointList/StatusEquals"
        {
            $v = "Creating","Deleting","Failed","InService","OutOfService","RollingBack","SystemUpdating","Updating"
            break
        }

        # Amazon.SageMaker.ExecutionStatus
        "Get-SMMonitoringExecutionList/StatusEquals"
        {
            $v = "Completed","CompletedWithViolations","Failed","InProgress","Pending","Stopped","Stopping"
            break
        }

        # Amazon.SageMaker.FeatureGroupSortBy
        "Get-SMFeatureGroupList/SortBy"
        {
            $v = "CreationTime","FeatureGroupStatus","Name","OfflineStoreStatus"
            break
        }

        # Amazon.SageMaker.FeatureGroupSortOrder
        "Get-SMFeatureGroupList/SortOrder"
        {
            $v = "Ascending","Descending"
            break
        }

        # Amazon.SageMaker.FeatureGroupStatus
        "Get-SMFeatureGroupList/FeatureGroupStatusEquals"
        {
            $v = "Created","CreateFailed","Creating","DeleteFailed","Deleting"
            break
        }

        # Amazon.SageMaker.Framework
        "New-SMCompilationJob/InputConfig_Framework"
        {
            $v = "DARKNET","KERAS","MXNET","ONNX","PYTORCH","SKLEARN","TENSORFLOW","TFLITE","XGBOOST"
            break
        }

        # Amazon.SageMaker.HyperParameterTuningJobObjectiveType
        {
            ($_ -eq "New-SMHyperParameterTuningJob/HyperParameterTuningJobConfig_HyperParameterTuningJobObjective_Type") -Or
            ($_ -eq "New-SMHyperParameterTuningJob/TrainingJobDefinition_TuningObjective_Type")
        }
        {
            $v = "Maximize","Minimize"
            break
        }

        # Amazon.SageMaker.HyperParameterTuningJobSortByOptions
        "Get-SMHyperParameterTuningJobList/SortBy"
        {
            $v = "CreationTime","Name","Status"
            break
        }

        # Amazon.SageMaker.HyperParameterTuningJobStatus
        "Get-SMHyperParameterTuningJobList/StatusEquals"
        {
            $v = "Completed","Failed","InProgress","Stopped","Stopping"
            break
        }

        # Amazon.SageMaker.HyperParameterTuningJobStrategyType
        "New-SMHyperParameterTuningJob/HyperParameterTuningJobConfig_Strategy"
        {
            $v = "Bayesian","Random"
            break
        }

        # Amazon.SageMaker.HyperParameterTuningJobWarmStartType
        "New-SMHyperParameterTuningJob/WarmStartConfig_WarmStartType"
        {
            $v = "IdenticalDataAndAlgorithm","TransferLearning"
            break
        }

        # Amazon.SageMaker.ImageSortBy
        "Get-SMImageList/SortBy"
        {
            $v = "CREATION_TIME","IMAGE_NAME","LAST_MODIFIED_TIME"
            break
        }

        # Amazon.SageMaker.ImageSortOrder
        "Get-SMImageList/SortOrder"
        {
            $v = "ASCENDING","DESCENDING"
            break
        }

        # Amazon.SageMaker.ImageVersionSortBy
        "Get-SMImageVersionList/SortBy"
        {
            $v = "CREATION_TIME","LAST_MODIFIED_TIME","VERSION"
            break
        }

        # Amazon.SageMaker.ImageVersionSortOrder
        "Get-SMImageVersionList/SortOrder"
        {
            $v = "ASCENDING","DESCENDING"
            break
        }

        # Amazon.SageMaker.InferenceExecutionMode
        "New-SMModel/InferenceExecutionConfig_Mode"
        {
            $v = "Direct","Serial"
            break
        }

        # Amazon.SageMaker.InstanceType
        {
            ($_ -eq "New-SMNotebookInstance/InstanceType") -Or
            ($_ -eq "Update-SMNotebookInstance/InstanceType")
        }
        {
            $v = "ml.c4.2xlarge","ml.c4.4xlarge","ml.c4.8xlarge","ml.c4.xlarge","ml.c5.18xlarge","ml.c5.2xlarge","ml.c5.4xlarge","ml.c5.9xlarge","ml.c5.xlarge","ml.c5d.18xlarge","ml.c5d.2xlarge","ml.c5d.4xlarge","ml.c5d.9xlarge","ml.c5d.xlarge","ml.g4dn.12xlarge","ml.g4dn.16xlarge","ml.g4dn.2xlarge","ml.g4dn.4xlarge","ml.g4dn.8xlarge","ml.g4dn.xlarge","ml.m4.10xlarge","ml.m4.16xlarge","ml.m4.2xlarge","ml.m4.4xlarge","ml.m4.xlarge","ml.m5.12xlarge","ml.m5.24xlarge","ml.m5.2xlarge","ml.m5.4xlarge","ml.m5.xlarge","ml.m5d.12xlarge","ml.m5d.16xlarge","ml.m5d.24xlarge","ml.m5d.2xlarge","ml.m5d.4xlarge","ml.m5d.8xlarge","ml.m5d.large","ml.m5d.xlarge","ml.p2.16xlarge","ml.p2.8xlarge","ml.p2.xlarge","ml.p3.16xlarge","ml.p3.2xlarge","ml.p3.8xlarge","ml.p3dn.24xlarge","ml.r5.12xlarge","ml.r5.16xlarge","ml.r5.24xlarge","ml.r5.2xlarge","ml.r5.4xlarge","ml.r5.8xlarge","ml.r5.large","ml.r5.xlarge","ml.t2.2xlarge","ml.t2.large","ml.t2.medium","ml.t2.xlarge","ml.t3.2xlarge","ml.t3.large","ml.t3.medium","ml.t3.xlarge"
            break
        }

        # Amazon.SageMaker.JoinSource
        "New-SMTransformJob/DataProcessing_JoinSource"
        {
            $v = "Input","None"
            break
        }

        # Amazon.SageMaker.LabelingJobStatus
        "Get-SMLabelingJobList/StatusEquals"
        {
            $v = "Completed","Failed","Initializing","InProgress","Stopped","Stopping"
            break
        }

        # Amazon.SageMaker.ListCompilationJobsSortBy
        "Get-SMCompilationJobList/SortBy"
        {
            $v = "CreationTime","Name","Status"
            break
        }

        # Amazon.SageMaker.ListDeviceFleetsSortBy
        "Get-SMDeviceFleetList/SortBy"
        {
            $v = "CREATION_TIME","LAST_MODIFIED_TIME","NAME"
            break
        }

        # Amazon.SageMaker.ListEdgePackagingJobsSortBy
        "Get-SMEdgePackagingJobList/SortBy"
        {
            $v = "CREATION_TIME","LAST_MODIFIED_TIME","MODEL_NAME","NAME","STATUS"
            break
        }

        # Amazon.SageMaker.ListLabelingJobsForWorkteamSortByOptions
        "Get-SMLabelingJobListForWorkteam/SortBy"
        {
            $v = "CreationTime"
            break
        }

        # Amazon.SageMaker.ListWorkforcesSortByOptions
        "Get-SMWorkforceList/SortBy"
        {
            $v = "CreateDate","Name"
            break
        }

        # Amazon.SageMaker.ListWorkteamsSortByOptions
        "Get-SMWorkteamList/SortBy"
        {
            $v = "CreateDate","Name"
            break
        }

        # Amazon.SageMaker.ModelApprovalStatus
        {
            ($_ -eq "Get-SMModelPackageList/ModelApprovalStatus") -Or
            ($_ -eq "New-SMModelPackage/ModelApprovalStatus") -Or
            ($_ -eq "Update-SMModelPackage/ModelApprovalStatus")
        }
        {
            $v = "Approved","PendingManualApproval","Rejected"
            break
        }

        # Amazon.SageMaker.ModelPackageGroupSortBy
        "Get-SMModelPackageGroupList/SortBy"
        {
            $v = "CreationTime","Name"
            break
        }

        # Amazon.SageMaker.ModelPackageSortBy
        "Get-SMModelPackageList/SortBy"
        {
            $v = "CreationTime","Name"
            break
        }

        # Amazon.SageMaker.ModelPackageType
        "Get-SMModelPackageList/ModelPackageType"
        {
            $v = "Both","Unversioned","Versioned"
            break
        }

        # Amazon.SageMaker.ModelSortKey
        "Get-SMModelList/SortBy"
        {
            $v = "CreationTime","Name"
            break
        }

        # Amazon.SageMaker.MonitoringExecutionSortKey
        "Get-SMMonitoringExecutionList/SortBy"
        {
            $v = "CreationTime","ScheduledTime","Status"
            break
        }

        # Amazon.SageMaker.MonitoringJobDefinitionSortKey
        {
            ($_ -eq "Get-SMDataQualityJobDefinitionList/SortBy") -Or
            ($_ -eq "Get-SMModelBiasJobDefinitionList/SortBy") -Or
            ($_ -eq "Get-SMModelExplainabilityJobDefinitionList/SortBy") -Or
            ($_ -eq "Get-SMModelQualityJobDefinitionList/SortBy")
        }
        {
            $v = "CreationTime","Name"
            break
        }

        # Amazon.SageMaker.MonitoringProblemType
        "New-SMModelQualityJobDefinition/ModelQualityAppSpecification_ProblemType"
        {
            $v = "BinaryClassification","MulticlassClassification","Regression"
            break
        }

        # Amazon.SageMaker.MonitoringScheduleSortKey
        "Get-SMMonitoringScheduleList/SortBy"
        {
            $v = "CreationTime","Name","Status"
            break
        }

        # Amazon.SageMaker.MonitoringType
        {
            ($_ -eq "Get-SMMonitoringExecutionList/MonitoringTypeEquals") -Or
            ($_ -eq "Get-SMMonitoringScheduleList/MonitoringTypeEquals")
        }
        {
            $v = "DataQuality","ModelBias","ModelExplainability","ModelQuality"
            break
        }

        # Amazon.SageMaker.NotebookInstanceLifecycleConfigSortKey
        "Get-SMNotebookInstanceLifecycleConfigList/SortBy"
        {
            $v = "CreationTime","LastModifiedTime","Name"
            break
        }

        # Amazon.SageMaker.NotebookInstanceLifecycleConfigSortOrder
        "Get-SMNotebookInstanceLifecycleConfigList/SortOrder"
        {
            $v = "Ascending","Descending"
            break
        }

        # Amazon.SageMaker.NotebookInstanceSortKey
        "Get-SMNotebookInstanceList/SortBy"
        {
            $v = "CreationTime","Name","Status"
            break
        }

        # Amazon.SageMaker.NotebookInstanceSortOrder
        "Get-SMNotebookInstanceList/SortOrder"
        {
            $v = "Ascending","Descending"
            break
        }

        # Amazon.SageMaker.NotebookInstanceStatus
        "Get-SMNotebookInstanceList/StatusEquals"
        {
            $v = "Deleting","Failed","InService","Pending","Stopped","Stopping","Updating"
            break
        }

        # Amazon.SageMaker.OfflineStoreStatusValue
        "Get-SMFeatureGroupList/OfflineStoreStatusEquals"
        {
            $v = "Active","Blocked","Disabled"
            break
        }

        # Amazon.SageMaker.OrderKey
        {
            ($_ -eq "Get-SMConfigList/SortOrder") -Or
            ($_ -eq "Get-SMEndpointList/SortOrder") -Or
            ($_ -eq "Get-SMModelList/SortOrder")
        }
        {
            $v = "Ascending","Descending"
            break
        }

        # Amazon.SageMaker.ProblemType
        "New-SMAutoMLJob/ProblemType"
        {
            $v = "BinaryClassification","MulticlassClassification","Regression"
            break
        }

        # Amazon.SageMaker.ProcessingInstanceType
        {
            ($_ -eq "New-SMDataQualityJobDefinition/JobResources_ClusterConfig_InstanceType") -Or
            ($_ -eq "New-SMModelBiasJobDefinition/JobResources_ClusterConfig_InstanceType") -Or
            ($_ -eq "New-SMModelExplainabilityJobDefinition/JobResources_ClusterConfig_InstanceType") -Or
            ($_ -eq "New-SMModelQualityJobDefinition/JobResources_ClusterConfig_InstanceType") -Or
            ($_ -eq "New-SMProcessingJob/ProcessingResources_ClusterConfig_InstanceType")
        }
        {
            $v = "ml.c4.2xlarge","ml.c4.4xlarge","ml.c4.8xlarge","ml.c4.xlarge","ml.c5.18xlarge","ml.c5.2xlarge","ml.c5.4xlarge","ml.c5.9xlarge","ml.c5.xlarge","ml.g4dn.12xlarge","ml.g4dn.16xlarge","ml.g4dn.2xlarge","ml.g4dn.4xlarge","ml.g4dn.8xlarge","ml.g4dn.xlarge","ml.m4.10xlarge","ml.m4.16xlarge","ml.m4.2xlarge","ml.m4.4xlarge","ml.m4.xlarge","ml.m5.12xlarge","ml.m5.24xlarge","ml.m5.2xlarge","ml.m5.4xlarge","ml.m5.large","ml.m5.xlarge","ml.p2.16xlarge","ml.p2.8xlarge","ml.p2.xlarge","ml.p3.16xlarge","ml.p3.2xlarge","ml.p3.8xlarge","ml.r5.12xlarge","ml.r5.16xlarge","ml.r5.24xlarge","ml.r5.2xlarge","ml.r5.4xlarge","ml.r5.8xlarge","ml.r5.large","ml.r5.xlarge","ml.t3.2xlarge","ml.t3.large","ml.t3.medium","ml.t3.xlarge"
            break
        }

        # Amazon.SageMaker.ProcessingJobStatus
        "Get-SMProcessingJobList/StatusEquals"
        {
            $v = "Completed","Failed","InProgress","Stopped","Stopping"
            break
        }

        # Amazon.SageMaker.ProcessingS3DataDistributionType
        {
            ($_ -eq "New-SMDataQualityJobDefinition/DataQualityJobInput_EndpointInput_S3DataDistributionType") -Or
            ($_ -eq "New-SMModelBiasJobDefinition/ModelBiasJobInput_EndpointInput_S3DataDistributionType") -Or
            ($_ -eq "New-SMModelExplainabilityJobDefinition/ModelExplainabilityJobInput_EndpointInput_S3DataDistributionType") -Or
            ($_ -eq "New-SMModelQualityJobDefinition/ModelQualityJobInput_EndpointInput_S3DataDistributionType")
        }
        {
            $v = "FullyReplicated","ShardedByS3Key"
            break
        }

        # Amazon.SageMaker.ProcessingS3InputMode
        {
            ($_ -eq "New-SMDataQualityJobDefinition/DataQualityJobInput_EndpointInput_S3InputMode") -Or
            ($_ -eq "New-SMModelBiasJobDefinition/ModelBiasJobInput_EndpointInput_S3InputMode") -Or
            ($_ -eq "New-SMModelExplainabilityJobDefinition/ModelExplainabilityJobInput_EndpointInput_S3InputMode") -Or
            ($_ -eq "New-SMModelQualityJobDefinition/ModelQualityJobInput_EndpointInput_S3InputMode")
        }
        {
            $v = "File","Pipe"
            break
        }

        # Amazon.SageMaker.ProjectSortBy
        "Get-SMProjectList/SortBy"
        {
            $v = "CreationTime","Name"
            break
        }

        # Amazon.SageMaker.ProjectSortOrder
        "Get-SMProjectList/SortOrder"
        {
            $v = "Ascending","Descending"
            break
        }

        # Amazon.SageMaker.ResourceType
        {
            ($_ -eq "Get-SMSearchSuggestion/Resource") -Or
            ($_ -eq "Search-SMResource/Resource")
        }
        {
            $v = "Endpoint","Experiment","ExperimentTrial","ExperimentTrialComponent","FeatureGroup","ModelPackage","ModelPackageGroup","Pipeline","PipelineExecution","Project","TrainingJob"
            break
        }

        # Amazon.SageMaker.RetentionType
        "Remove-SMDomain/RetentionPolicy_HomeEfsFileSystem"
        {
            $v = "Delete","Retain"
            break
        }

        # Amazon.SageMaker.RootAccess
        {
            ($_ -eq "New-SMNotebookInstance/RootAccess") -Or
            ($_ -eq "Update-SMNotebookInstance/RootAccess")
        }
        {
            $v = "Disabled","Enabled"
            break
        }

        # Amazon.SageMaker.S3DataType
        "New-SMTransformJob/TransformInput_DataSource_S3DataSource_S3DataType"
        {
            $v = "AugmentedManifestFile","ManifestFile","S3Prefix"
            break
        }

        # Amazon.SageMaker.ScheduleStatus
        "Get-SMMonitoringScheduleList/StatusEquals"
        {
            $v = "Failed","Pending","Scheduled","Stopped"
            break
        }

        # Amazon.SageMaker.SearchSortOrder
        "Search-SMResource/SortOrder"
        {
            $v = "Ascending","Descending"
            break
        }

        # Amazon.SageMaker.SortActionsBy
        "Get-SMActionList/SortBy"
        {
            $v = "CreationTime","Name"
            break
        }

        # Amazon.SageMaker.SortArtifactsBy
        "Get-SMArtifactList/SortBy"
        {
            $v = "CreationTime"
            break
        }

        # Amazon.SageMaker.SortAssociationsBy
        "Get-SMAssociationList/SortBy"
        {
            $v = "CreationTime","DestinationArn","DestinationType","SourceArn","SourceType"
            break
        }

        # Amazon.SageMaker.SortBy
        {
            ($_ -eq "Get-SMLabelingJobList/SortBy") -Or
            ($_ -eq "Get-SMProcessingJobList/SortBy") -Or
            ($_ -eq "Get-SMTrainingJobList/SortBy") -Or
            ($_ -eq "Get-SMTransformJobList/SortBy")
        }
        {
            $v = "CreationTime","Name","Status"
            break
        }

        # Amazon.SageMaker.SortContextsBy
        "Get-SMContextList/SortBy"
        {
            $v = "CreationTime","Name"
            break
        }

        # Amazon.SageMaker.SortExperimentsBy
        "Get-SMExperimentList/SortBy"
        {
            $v = "CreationTime","Name"
            break
        }

        # Amazon.SageMaker.SortOrder
        {
            ($_ -eq "Get-SMActionList/SortOrder") -Or
            ($_ -eq "Get-SMAlgorithmList/SortOrder") -Or
            ($_ -eq "Get-SMAppImageConfigList/SortOrder") -Or
            ($_ -eq "Get-SMAppList/SortOrder") -Or
            ($_ -eq "Get-SMArtifactList/SortOrder") -Or
            ($_ -eq "Get-SMAssociationList/SortOrder") -Or
            ($_ -eq "Get-SMCompilationJobList/SortOrder") -Or
            ($_ -eq "Get-SMContextList/SortOrder") -Or
            ($_ -eq "Get-SMDataQualityJobDefinitionList/SortOrder") -Or
            ($_ -eq "Get-SMDeviceFleetList/SortOrder") -Or
            ($_ -eq "Get-SMEdgePackagingJobList/SortOrder") -Or
            ($_ -eq "Get-SMExperimentList/SortOrder") -Or
            ($_ -eq "Get-SMFlowDefinitionList/SortOrder") -Or
            ($_ -eq "Get-SMHumanTaskUiList/SortOrder") -Or
            ($_ -eq "Get-SMHyperParameterTuningJobList/SortOrder") -Or
            ($_ -eq "Get-SMLabelingJobList/SortOrder") -Or
            ($_ -eq "Get-SMLabelingJobListForWorkteam/SortOrder") -Or
            ($_ -eq "Get-SMModelBiasJobDefinitionList/SortOrder") -Or
            ($_ -eq "Get-SMModelExplainabilityJobDefinitionList/SortOrder") -Or
            ($_ -eq "Get-SMModelPackageGroupList/SortOrder") -Or
            ($_ -eq "Get-SMModelPackageList/SortOrder") -Or
            ($_ -eq "Get-SMModelQualityJobDefinitionList/SortOrder") -Or
            ($_ -eq "Get-SMMonitoringExecutionList/SortOrder") -Or
            ($_ -eq "Get-SMMonitoringScheduleList/SortOrder") -Or
            ($_ -eq "Get-SMPipelineExecutionList/SortOrder") -Or
            ($_ -eq "Get-SMPipelineExecutionStepList/SortOrder") -Or
            ($_ -eq "Get-SMPipelineList/SortOrder") -Or
            ($_ -eq "Get-SMProcessingJobList/SortOrder") -Or
            ($_ -eq "Get-SMStudioLifecycleConfigList/SortOrder") -Or
            ($_ -eq "Get-SMTrainingJobList/SortOrder") -Or
            ($_ -eq "Get-SMTrainingJobsForHyperParameterTuningJobList/SortOrder") -Or
            ($_ -eq "Get-SMTransformJobList/SortOrder") -Or
            ($_ -eq "Get-SMTrialComponentList/SortOrder") -Or
            ($_ -eq "Get-SMTrialList/SortOrder") -Or
            ($_ -eq "Get-SMUserProfileList/SortOrder") -Or
            ($_ -eq "Get-SMWorkforceList/SortOrder") -Or
            ($_ -eq "Get-SMWorkteamList/SortOrder")
        }
        {
            $v = "Ascending","Descending"
            break
        }

        # Amazon.SageMaker.SortPipelineExecutionsBy
        "Get-SMPipelineExecutionList/SortBy"
        {
            $v = "CreationTime","PipelineExecutionArn"
            break
        }

        # Amazon.SageMaker.SortPipelinesBy
        "Get-SMPipelineList/SortBy"
        {
            $v = "CreationTime","Name"
            break
        }

        # Amazon.SageMaker.SortTrialComponentsBy
        "Get-SMTrialComponentList/SortBy"
        {
            $v = "CreationTime","Name"
            break
        }

        # Amazon.SageMaker.SortTrialsBy
        "Get-SMTrialList/SortBy"
        {
            $v = "CreationTime","Name"
            break
        }

        # Amazon.SageMaker.SplitType
        "New-SMTransformJob/TransformInput_SplitType"
        {
            $v = "Line","None","RecordIO","TFRecord"
            break
        }

        # Amazon.SageMaker.StudioLifecycleConfigAppType
        {
            ($_ -eq "Get-SMStudioLifecycleConfigList/AppTypeEquals") -Or
            ($_ -eq "New-SMStudioLifecycleConfig/StudioLifecycleConfigAppType")
        }
        {
            $v = "JupyterServer","KernelGateway"
            break
        }

        # Amazon.SageMaker.StudioLifecycleConfigSortKey
        "Get-SMStudioLifecycleConfigList/SortBy"
        {
            $v = "CreationTime","LastModifiedTime","Name"
            break
        }

        # Amazon.SageMaker.TargetDevice
        "New-SMCompilationJob/OutputConfig_TargetDevice"
        {
            $v = "aisage","amba_cv22","amba_cv25","coreml","deeplens","imx8mplus","imx8qm","jacinto_tda4vm","jetson_nano","jetson_tx1","jetson_tx2","jetson_xavier","lambda","ml_c4","ml_c5","ml_eia2","ml_g4dn","ml_inf1","ml_m4","ml_m5","ml_p2","ml_p3","qcs603","qcs605","rasp3b","rk3288","rk3399","sbe_c","sitara_am57x","x86_win32","x86_win64"
            break
        }

        # Amazon.SageMaker.TargetPlatformAccelerator
        "New-SMCompilationJob/OutputConfig_TargetPlatform_Accelerator"
        {
            $v = "INTEL_GRAPHICS","MALI","NVIDIA"
            break
        }

        # Amazon.SageMaker.TargetPlatformArch
        "New-SMCompilationJob/OutputConfig_TargetPlatform_Arch"
        {
            $v = "ARM64","ARM_EABI","ARM_EABIHF","X86","X86_64"
            break
        }

        # Amazon.SageMaker.TargetPlatformOs
        "New-SMCompilationJob/OutputConfig_TargetPlatform_Os"
        {
            $v = "ANDROID","LINUX"
            break
        }

        # Amazon.SageMaker.TrafficRoutingConfigType
        "Update-SMEndpoint/DeploymentConfig_BlueGreenUpdatePolicy_TrafficRoutingConfiguration_Type"
        {
            $v = "ALL_AT_ONCE","CANARY"
            break
        }

        # Amazon.SageMaker.TrainingInputMode
        "New-SMHyperParameterTuningJob/TrainingJobDefinition_AlgorithmSpecification_TrainingInputMode"
        {
            $v = "File","Pipe"
            break
        }

        # Amazon.SageMaker.TrainingJobEarlyStoppingType
        "New-SMHyperParameterTuningJob/HyperParameterTuningJobConfig_TrainingJobEarlyStoppingType"
        {
            $v = "Auto","Off"
            break
        }

        # Amazon.SageMaker.TrainingJobSortByOptions
        "Get-SMTrainingJobsForHyperParameterTuningJobList/SortBy"
        {
            $v = "CreationTime","FinalObjectiveMetricValue","Name","Status"
            break
        }

        # Amazon.SageMaker.TrainingJobStatus
        {
            ($_ -eq "Get-SMTrainingJobList/StatusEquals") -Or
            ($_ -eq "Get-SMTrainingJobsForHyperParameterTuningJobList/StatusEquals")
        }
        {
            $v = "Completed","Failed","InProgress","Stopped","Stopping"
            break
        }

        # Amazon.SageMaker.TransformInstanceType
        "New-SMTransformJob/TransformResources_InstanceType"
        {
            $v = "ml.c4.2xlarge","ml.c4.4xlarge","ml.c4.8xlarge","ml.c4.xlarge","ml.c5.18xlarge","ml.c5.2xlarge","ml.c5.4xlarge","ml.c5.9xlarge","ml.c5.xlarge","ml.g4dn.12xlarge","ml.g4dn.16xlarge","ml.g4dn.2xlarge","ml.g4dn.4xlarge","ml.g4dn.8xlarge","ml.g4dn.xlarge","ml.m4.10xlarge","ml.m4.16xlarge","ml.m4.2xlarge","ml.m4.4xlarge","ml.m4.xlarge","ml.m5.12xlarge","ml.m5.24xlarge","ml.m5.2xlarge","ml.m5.4xlarge","ml.m5.large","ml.m5.xlarge","ml.p2.16xlarge","ml.p2.8xlarge","ml.p2.xlarge","ml.p3.16xlarge","ml.p3.2xlarge","ml.p3.8xlarge"
            break
        }

        # Amazon.SageMaker.TransformJobStatus
        "Get-SMTransformJobList/StatusEquals"
        {
            $v = "Completed","Failed","InProgress","Stopped","Stopping"
            break
        }

        # Amazon.SageMaker.TrialComponentPrimaryStatus
        {
            ($_ -eq "New-SMTrialComponent/Status_PrimaryStatus") -Or
            ($_ -eq "Update-SMTrialComponent/Status_PrimaryStatus")
        }
        {
            $v = "Completed","Failed","InProgress","Stopped","Stopping"
            break
        }

        # Amazon.SageMaker.UserProfileSortKey
        "Get-SMUserProfileList/SortBy"
        {
            $v = "CreationTime","LastModifiedTime"
            break
        }


    }

    $v |
        Where-Object { $_ -like "$wordToComplete*" } |
        ForEach-Object { New-Object System.Management.Automation.CompletionResult $_, $_, 'ParameterValue', $_ }
}

$SM_map = @{
    "AppNetworkAccessType"=@("New-SMDomain")
    "AppType"=@("Get-SMApp","New-SMApp","Remove-SMApp")
    "AppTypeEquals"=@("Get-SMStudioLifecycleConfigList")
    "AssociationType"=@("Add-SMAssociation","Get-SMAssociationList")
    "AuthMode"=@("New-SMDomain")
    "AutoMLJobObjective_MetricName"=@("New-SMAutoMLJob")
    "BatchStrategy"=@("New-SMTransformJob")
    "DataProcessing_JoinSource"=@("New-SMTransformJob")
    "DataQualityJobInput_EndpointInput_S3DataDistributionType"=@("New-SMDataQualityJobDefinition")
    "DataQualityJobInput_EndpointInput_S3InputMode"=@("New-SMDataQualityJobDefinition")
    "DeploymentConfig_BlueGreenUpdatePolicy_TrafficRoutingConfiguration_CanarySize_Type"=@("Update-SMEndpoint")
    "DeploymentConfig_BlueGreenUpdatePolicy_TrafficRoutingConfiguration_Type"=@("Update-SMEndpoint")
    "DirectInternetAccess"=@("New-SMNotebookInstance")
    "FeatureGroupStatusEquals"=@("Get-SMFeatureGroupList")
    "HumanLoopRequestSource_AwsManagedHumanLoopRequestSource"=@("New-SMFlowDefinition")
    "HyperParameterTuningJobConfig_HyperParameterTuningJobObjective_Type"=@("New-SMHyperParameterTuningJob")
    "HyperParameterTuningJobConfig_Strategy"=@("New-SMHyperParameterTuningJob")
    "HyperParameterTuningJobConfig_TrainingJobEarlyStoppingType"=@("New-SMHyperParameterTuningJob")
    "InferenceExecutionConfig_Mode"=@("New-SMModel")
    "InputConfig_Framework"=@("New-SMCompilationJob")
    "InstanceType"=@("New-SMNotebookInstance","Update-SMNotebookInstance")
    "JobResources_ClusterConfig_InstanceType"=@("New-SMDataQualityJobDefinition","New-SMModelBiasJobDefinition","New-SMModelExplainabilityJobDefinition","New-SMModelQualityJobDefinition")
    "ModelApprovalStatus"=@("Get-SMModelPackageList","New-SMModelPackage","Update-SMModelPackage")
    "ModelBiasJobInput_EndpointInput_S3DataDistributionType"=@("New-SMModelBiasJobDefinition")
    "ModelBiasJobInput_EndpointInput_S3InputMode"=@("New-SMModelBiasJobDefinition")
    "ModelExplainabilityJobInput_EndpointInput_S3DataDistributionType"=@("New-SMModelExplainabilityJobDefinition")
    "ModelExplainabilityJobInput_EndpointInput_S3InputMode"=@("New-SMModelExplainabilityJobDefinition")
    "ModelPackageType"=@("Get-SMModelPackageList")
    "ModelQualityAppSpecification_ProblemType"=@("New-SMModelQualityJobDefinition")
    "ModelQualityJobInput_EndpointInput_S3DataDistributionType"=@("New-SMModelQualityJobDefinition")
    "ModelQualityJobInput_EndpointInput_S3InputMode"=@("New-SMModelQualityJobDefinition")
    "MonitoringTypeEquals"=@("Get-SMMonitoringExecutionList","Get-SMMonitoringScheduleList")
    "OfflineStoreStatusEquals"=@("Get-SMFeatureGroupList")
    "OutputConfig_PresetDeploymentType"=@("New-SMDeviceFleet","New-SMEdgePackagingJob","Update-SMDeviceFleet")
    "OutputConfig_TargetDevice"=@("New-SMCompilationJob")
    "OutputConfig_TargetPlatform_Accelerator"=@("New-SMCompilationJob")
    "OutputConfig_TargetPlatform_Arch"=@("New-SMCompilationJob")
    "OutputConfig_TargetPlatform_Os"=@("New-SMCompilationJob")
    "ProblemType"=@("New-SMAutoMLJob")
    "ProcessingResources_ClusterConfig_InstanceType"=@("New-SMProcessingJob")
    "Resource"=@("Get-SMSearchSuggestion","Search-SMResource")
    "ResourceSpec_InstanceType"=@("New-SMApp")
    "RetentionPolicy_HomeEfsFileSystem"=@("Remove-SMDomain")
    "RootAccess"=@("New-SMNotebookInstance","Update-SMNotebookInstance")
    "SearchExpression_Operator"=@("Search-SMResource")
    "SortBy"=@("Get-SMActionList","Get-SMAlgorithmList","Get-SMAppImageConfigList","Get-SMAppList","Get-SMArtifactList","Get-SMAssociationList","Get-SMAutoMLJobList","Get-SMCandidatesForAutoMLJobList","Get-SMCodeRepositoryList","Get-SMCompilationJobList","Get-SMConfigList","Get-SMContextList","Get-SMDataQualityJobDefinitionList","Get-SMDeviceFleetList","Get-SMEdgePackagingJobList","Get-SMEndpointList","Get-SMExperimentList","Get-SMFeatureGroupList","Get-SMHyperParameterTuningJobList","Get-SMImageList","Get-SMImageVersionList","Get-SMLabelingJobList","Get-SMLabelingJobListForWorkteam","Get-SMModelBiasJobDefinitionList","Get-SMModelExplainabilityJobDefinitionList","Get-SMModelList","Get-SMModelPackageGroupList","Get-SMModelPackageList","Get-SMModelQualityJobDefinitionList","Get-SMMonitoringExecutionList","Get-SMMonitoringScheduleList","Get-SMNotebookInstanceLifecycleConfigList","Get-SMNotebookInstanceList","Get-SMPipelineExecutionList","Get-SMPipelineList","Get-SMProcessingJobList","Get-SMProjectList","Get-SMStudioLifecycleConfigList","Get-SMTrainingJobList","Get-SMTrainingJobsForHyperParameterTuningJobList","Get-SMTransformJobList","Get-SMTrialComponentList","Get-SMTrialList","Get-SMUserProfileList","Get-SMWorkforceList","Get-SMWorkteamList")
    "SortOrder"=@("Get-SMActionList","Get-SMAlgorithmList","Get-SMAppImageConfigList","Get-SMAppList","Get-SMArtifactList","Get-SMAssociationList","Get-SMAutoMLJobList","Get-SMCandidatesForAutoMLJobList","Get-SMCodeRepositoryList","Get-SMCompilationJobList","Get-SMConfigList","Get-SMContextList","Get-SMDataQualityJobDefinitionList","Get-SMDeviceFleetList","Get-SMEdgePackagingJobList","Get-SMEndpointList","Get-SMExperimentList","Get-SMFeatureGroupList","Get-SMFlowDefinitionList","Get-SMHumanTaskUiList","Get-SMHyperParameterTuningJobList","Get-SMImageList","Get-SMImageVersionList","Get-SMLabelingJobList","Get-SMLabelingJobListForWorkteam","Get-SMModelBiasJobDefinitionList","Get-SMModelExplainabilityJobDefinitionList","Get-SMModelList","Get-SMModelPackageGroupList","Get-SMModelPackageList","Get-SMModelQualityJobDefinitionList","Get-SMMonitoringExecutionList","Get-SMMonitoringScheduleList","Get-SMNotebookInstanceLifecycleConfigList","Get-SMNotebookInstanceList","Get-SMPipelineExecutionList","Get-SMPipelineExecutionStepList","Get-SMPipelineList","Get-SMProcessingJobList","Get-SMProjectList","Get-SMStudioLifecycleConfigList","Get-SMTrainingJobList","Get-SMTrainingJobsForHyperParameterTuningJobList","Get-SMTransformJobList","Get-SMTrialComponentList","Get-SMTrialList","Get-SMUserProfileList","Get-SMWorkforceList","Get-SMWorkteamList","Search-SMResource")
    "Status"=@("New-SMAction","Update-SMAction")
    "Status_PrimaryStatus"=@("New-SMTrialComponent","Update-SMTrialComponent")
    "StatusEquals"=@("Get-SMAutoMLJobList","Get-SMCandidatesForAutoMLJobList","Get-SMCompilationJobList","Get-SMEdgePackagingJobList","Get-SMEndpointList","Get-SMHyperParameterTuningJobList","Get-SMLabelingJobList","Get-SMMonitoringExecutionList","Get-SMMonitoringScheduleList","Get-SMNotebookInstanceList","Get-SMProcessingJobList","Get-SMTrainingJobList","Get-SMTrainingJobsForHyperParameterTuningJobList","Get-SMTransformJobList")
    "StudioLifecycleConfigAppType"=@("New-SMStudioLifecycleConfig")
    "TrainingJobDefinition_AlgorithmSpecification_TrainingInputMode"=@("New-SMHyperParameterTuningJob")
    "TrainingJobDefinition_TuningObjective_Type"=@("New-SMHyperParameterTuningJob")
    "TransformInput_CompressionType"=@("New-SMTransformJob")
    "TransformInput_DataSource_S3DataSource_S3DataType"=@("New-SMTransformJob")
    "TransformInput_SplitType"=@("New-SMTransformJob")
    "TransformOutput_AssembleWith"=@("New-SMTransformJob")
    "TransformResources_InstanceType"=@("New-SMTransformJob")
    "WarmStartConfig_WarmStartType"=@("New-SMHyperParameterTuningJob")
}

_awsArgumentCompleterRegistration $SM_Completers $SM_map

$SM_SelectCompleters = {
    param($commandName, $parameterName, $wordToComplete, $commandAst, $fakeBoundParameter)

    $cmdletType = Invoke-Expression "[Amazon.PowerShell.Cmdlets.SM.$($commandName.Replace('-', ''))Cmdlet]"
    if (-not $cmdletType) {
        return
    }
    $awsCmdletAttribute = $cmdletType.GetCustomAttributes([Amazon.PowerShell.Common.AWSCmdletAttribute], $false)
    if (-not $awsCmdletAttribute) {
        return
    }
    $type = $awsCmdletAttribute.SelectReturnType
    if (-not $type) {
        return
    }

    $splitSelect = $wordToComplete -Split '\.'
    $splitSelect | Select-Object -First ($splitSelect.Length - 1) | ForEach-Object {
        $propertyName = $_
        $properties = $type.GetProperties(('Instance', 'Public', 'DeclaredOnly')) | Where-Object { $_.Name -ieq $propertyName }
        if ($properties.Length -ne 1) {
            break
        }
        $type = $properties.PropertyType
        $prefix += "$($properties.Name)."

        $asEnumerableType = $type.GetInterface('System.Collections.Generic.IEnumerable`1')
        if ($asEnumerableType -and $type -ne [System.String]) {
            $type =  $asEnumerableType.GetGenericArguments()[0]
        }
    }

    $v = @( '*' )
    $properties = $type.GetProperties(('Instance', 'Public', 'DeclaredOnly')).Name | Sort-Object
    if ($properties) {
        $v += ($properties | ForEach-Object { $prefix + $_ })
    }
    $parameters = $cmdletType.GetProperties(('Instance', 'Public')) | Where-Object { $_.GetCustomAttributes([System.Management.Automation.ParameterAttribute], $true) } | Select-Object -ExpandProperty Name | Sort-Object
    if ($parameters) {
        $v += ($parameters | ForEach-Object { "^$_" })
    }

    $v |
        Where-Object { $_ -match "^$([System.Text.RegularExpressions.Regex]::Escape($wordToComplete)).*" } |
        ForEach-Object { New-Object System.Management.Automation.CompletionResult $_, $_, 'ParameterValue', $_ }
}

$SM_SelectMap = @{
    "Select"=@("Add-SMAssociation",
               "Add-SMResourceTag",
               "Register-SMTrialComponent",
               "New-SMAction",
               "New-SMAlgorithm",
               "New-SMApp",
               "New-SMAppImageConfig",
               "New-SMArtifact",
               "New-SMAutoMLJob",
               "New-SMCodeRepository",
               "New-SMCompilationJob",
               "New-SMContext",
               "New-SMDataQualityJobDefinition",
               "New-SMDeviceFleet",
               "New-SMDomain",
               "New-SMEdgePackagingJob",
               "New-SMEndpoint",
               "New-SMEndpointConfig",
               "New-SMExperiment",
               "New-SMFeatureGroup",
               "New-SMFlowDefinition",
               "New-SMHumanTaskUi",
               "New-SMHyperParameterTuningJob",
               "New-SMImage",
               "New-SMImageVersion",
               "New-SMLabelingJob",
               "New-SMModel",
               "New-SMModelBiasJobDefinition",
               "New-SMModelExplainabilityJobDefinition",
               "New-SMModelPackage",
               "New-SMModelPackageGroup",
               "New-SMModelQualityJobDefinition",
               "New-SMMonitoringSchedule",
               "New-SMNotebookInstance",
               "New-SMNotebookInstanceLifecycleConfig",
               "New-SMPipeline",
               "New-SMPresignedDomainUrl",
               "New-SMPresignedNotebookInstanceUrl",
               "New-SMProcessingJob",
               "New-SMProject",
               "New-SMStudioLifecycleConfig",
               "New-SMTrainingJob",
               "New-SMTransformJob",
               "New-SMTrial",
               "New-SMTrialComponent",
               "New-SMUserProfile",
               "New-SMWorkforce",
               "New-SMWorkteam",
               "Remove-SMAction",
               "Remove-SMAlgorithm",
               "Remove-SMApp",
               "Remove-SMAppImageConfig",
               "Remove-SMArtifact",
               "Remove-SMAssociation",
               "Remove-SMCodeRepository",
               "Remove-SMContext",
               "Remove-SMDataQualityJobDefinition",
               "Remove-SMDeviceFleet",
               "Remove-SMDomain",
               "Remove-SMEndpoint",
               "Remove-SMEndpointConfig",
               "Remove-SMExperiment",
               "Remove-SMFeatureGroup",
               "Remove-SMFlowDefinition",
               "Remove-SMHumanTaskUi",
               "Remove-SMImage",
               "Remove-SMImageVersion",
               "Remove-SMModel",
               "Remove-SMModelBiasJobDefinition",
               "Remove-SMModelExplainabilityJobDefinition",
               "Remove-SMModelPackage",
               "Remove-SMModelPackageGroup",
               "Remove-SMModelPackageGroupPolicy",
               "Remove-SMModelQualityJobDefinition",
               "Remove-SMMonitoringSchedule",
               "Remove-SMNotebookInstance",
               "Remove-SMNotebookInstanceLifecycleConfig",
               "Remove-SMPipeline",
               "Remove-SMProject",
               "Remove-SMStudioLifecycleConfig",
               "Remove-SMResourceTag",
               "Remove-SMTrial",
               "Remove-SMTrialComponent",
               "Remove-SMUserProfile",
               "Remove-SMWorkforce",
               "Remove-SMWorkteam",
               "Remove-SMDevice",
               "Get-SMAction",
               "Get-SMAlgorithm",
               "Get-SMApp",
               "Get-SMAppImageConfig",
               "Get-SMArtifact",
               "Get-SMAutoMLJob",
               "Get-SMCodeRepository",
               "Get-SMCompilationJob",
               "Get-SMContext",
               "Get-SMDataQualityJobDefinition",
               "Get-SMDevice",
               "Get-SMDeviceFleet",
               "Get-SMDomain",
               "Get-SMEdgePackagingJob",
               "Get-SMEndpoint",
               "Get-SMEndpointConfig",
               "Get-SMExperiment",
               "Get-SMFeatureGroup",
               "Get-SMFlowDefinition",
               "Get-SMHumanTaskUi",
               "Get-SMHyperParameterTuningJob",
               "Get-SMImage",
               "Get-SMImageVersion",
               "Get-SMLabelingJob",
               "Get-SMModel",
               "Get-SMModelBiasJobDefinition",
               "Get-SMModelExplainabilityJobDefinition",
               "Get-SMModelPackage",
               "Get-SMModelPackageGroup",
               "Get-SMModelQualityJobDefinition",
               "Get-SMMonitoringSchedule",
               "Get-SMNotebookInstance",
               "Get-SMNotebookInstanceLifecycleConfig",
               "Get-SMPipeline",
               "Get-SMPipelineDefinitionForExecution",
               "Get-SMPipelineExecution",
               "Get-SMProcessingJob",
               "Get-SMProject",
               "Get-SMStudioLifecycleConfig",
               "Get-SMSubscribedWorkteam",
               "Get-SMTrainingJob",
               "Get-SMTransformJob",
               "Get-SMTrial",
               "Get-SMTrialComponent",
               "Get-SMUserProfile",
               "Get-SMWorkforce",
               "Get-SMWorkteam",
               "Disable-SMSagemakerServicecatalogPortfolio",
               "Unregister-SMTrialComponent",
               "Enable-SMSagemakerServicecatalogPortfolio",
               "Get-SMDeviceFleetReport",
               "Get-SMModelPackageGroupPolicy",
               "Get-SMSagemakerServicecatalogPortfolioStatus",
               "Get-SMSearchSuggestion",
               "Get-SMActionList",
               "Get-SMAlgorithmList",
               "Get-SMAppImageConfigList",
               "Get-SMAppList",
               "Get-SMArtifactList",
               "Get-SMAssociationList",
               "Get-SMAutoMLJobList",
               "Get-SMCandidatesForAutoMLJobList",
               "Get-SMCodeRepositoryList",
               "Get-SMCompilationJobList",
               "Get-SMContextList",
               "Get-SMDataQualityJobDefinitionList",
               "Get-SMDeviceFleetList",
               "Get-SMDeviceList",
               "Get-SMDomainList",
               "Get-SMEdgePackagingJobList",
               "Get-SMConfigList",
               "Get-SMEndpointList",
               "Get-SMExperimentList",
               "Get-SMFeatureGroupList",
               "Get-SMFlowDefinitionList",
               "Get-SMHumanTaskUiList",
               "Get-SMHyperParameterTuningJobList",
               "Get-SMImageList",
               "Get-SMImageVersionList",
               "Get-SMLabelingJobList",
               "Get-SMLabelingJobListForWorkteam",
               "Get-SMModelBiasJobDefinitionList",
               "Get-SMModelExplainabilityJobDefinitionList",
               "Get-SMModelPackageGroupList",
               "Get-SMModelPackageList",
               "Get-SMModelQualityJobDefinitionList",
               "Get-SMModelList",
               "Get-SMMonitoringExecutionList",
               "Get-SMMonitoringScheduleList",
               "Get-SMNotebookInstanceLifecycleConfigList",
               "Get-SMNotebookInstanceList",
               "Get-SMPipelineExecutionList",
               "Get-SMPipelineExecutionStepList",
               "Get-SMPipelineParametersForExecutionList",
               "Get-SMPipelineList",
               "Get-SMProcessingJobList",
               "Get-SMProjectList",
               "Get-SMStudioLifecycleConfigList",
               "Get-SMSubscribedWorkteamList",
               "Get-SMResourceTagList",
               "Get-SMTrainingJobList",
               "Get-SMTrainingJobsForHyperParameterTuningJobList",
               "Get-SMTransformJobList",
               "Get-SMTrialComponentList",
               "Get-SMTrialList",
               "Get-SMUserProfileList",
               "Get-SMWorkforceList",
               "Get-SMWorkteamList",
               "Write-SMModelPackageGroupPolicy",
               "Register-SMDevice",
               "Invoke-SMUiTemplateRendering",
               "Restart-SMPipelineExecution",
               "Search-SMResource",
               "Send-SMPipelineExecutionStepFailure",
               "Send-SMPipelineExecutionStepSuccess",
               "Start-SMMonitoringSchedule",
               "Start-SMNotebookInstance",
               "Start-SMPipelineExecution",
               "Stop-SMAutoMLJob",
               "Stop-SMCompilationJob",
               "Stop-SMEdgePackagingJob",
               "Stop-SMHyperParameterTuningJob",
               "Stop-SMLabelingJob",
               "Stop-SMMonitoringSchedule",
               "Stop-SMNotebookInstance",
               "Stop-SMPipelineExecution",
               "Stop-SMProcessingJob",
               "Stop-SMTrainingJob",
               "Stop-SMTransformJob",
               "Update-SMAction",
               "Update-SMAppImageConfig",
               "Update-SMArtifact",
               "Update-SMCodeRepository",
               "Update-SMContext",
               "Update-SMDeviceFleet",
               "Update-SMDevice",
               "Update-SMDomain",
               "Update-SMEndpoint",
               "Update-SMEndpointWeightAndCapacity",
               "Update-SMExperiment",
               "Update-SMImage",
               "Update-SMModelPackage",
               "Update-SMMonitoringSchedule",
               "Update-SMNotebookInstance",
               "Update-SMNotebookInstanceLifecycleConfig",
               "Update-SMPipeline",
               "Update-SMPipelineExecution",
               "Update-SMTrainingJob",
               "Update-SMTrial",
               "Update-SMTrialComponent",
               "Update-SMUserProfile",
               "Update-SMWorkforce",
               "Update-SMWorkteam")
}

_awsArgumentCompleterRegistration $SM_SelectCompleters $SM_SelectMap

