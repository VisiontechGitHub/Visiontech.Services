﻿//------------------------------------------------------------------------------
// <generato automaticamente>
//     Questo codice è stato generato da uno strumento.
//     //
//     Le modifiche apportate a questo file possono causare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </generato automaticamente>
//------------------------------------------------------------------------------

namespace Org.Visiontech.Compute
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://soap.service.optoplus.visiontech.org/", ConfigurationName="Org.Visiontech.Compute.ComputeSoap")]
    public interface ComputeSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(computeLensResponseOmaSideDTO))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(twoDimensionalPointDTO))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(computeLensRequestOmaSideDTO))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(messageDTO))]
        System.Threading.Tasks.Task<Org.Visiontech.Compute.analyzeLensResponse> analyzeLensAsync(Org.Visiontech.Compute.analyzeLens request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(computeLensResponseOmaSideDTO))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(twoDimensionalPointDTO))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(computeLensRequestOmaSideDTO))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(messageDTO))]
        System.Threading.Tasks.Task<Org.Visiontech.Compute.computeLensResponse> computeLensAsync(Org.Visiontech.Compute.computeLens request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(computeLensResponseOmaSideDTO))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(twoDimensionalPointDTO))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(computeLensRequestOmaSideDTO))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(messageDTO))]
        System.Threading.Tasks.Task<Org.Visiontech.Compute.previewLensResponse> previewLensAsync(Org.Visiontech.Compute.previewLens request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class analyzeLensRequestDTO : computeRequestDTO
    {
        
        private threeDimensionalPointDTO[] pointsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("points", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=0)]
        public threeDimensionalPointDTO[] points
        {
            get
            {
                return this.pointsField;
            }
            set
            {
                this.pointsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(analyzedPointDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class threeDimensionalPointDTO : twoDimensionalPointDTO
    {
        
        private double zField;
        
        private bool zFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public double z
        {
            get
            {
                return this.zField;
            }
            set
            {
                this.zField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool zSpecified
        {
            get
            {
                return this.zFieldSpecified;
            }
            set
            {
                this.zFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(threeDimensionalPointDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(analyzedPointDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class twoDimensionalPointDTO
    {
        
        private double xField;
        
        private bool xFieldSpecified;
        
        private double yField;
        
        private bool yFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public double x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xSpecified
        {
            get
            {
                return this.xFieldSpecified;
            }
            set
            {
                this.xFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public double y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ySpecified
        {
            get
            {
                return this.yFieldSpecified;
            }
            set
            {
                this.yFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeLensResponseSideDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computeLensResponseOmaSideDTO
    {
        
        private int cribPerimeterThickestPointAngleField;
        
        private bool cribPerimeterThickestPointAngleFieldSpecified;
        
        private double cribPerimeterThickestPointThicknessField;
        
        private bool cribPerimeterThickestPointThicknessFieldSpecified;
        
        private int cribPerimeterThinnestPointAngleField;
        
        private bool cribPerimeterThinnestPointAngleFieldSpecified;
        
        private double cribPerimeterThinnestPointThicknessField;
        
        private bool cribPerimeterThinnestPointThicknessFieldSpecified;
        
        private double designedAdditionPowerField;
        
        private bool designedAdditionPowerFieldSpecified;
        
        private int designedDistanceReferencePointCylinderAxisField;
        
        private bool designedDistanceReferencePointCylinderAxisFieldSpecified;
        
        private double designedDistanceReferencePointCylinderPowerField;
        
        private bool designedDistanceReferencePointCylinderPowerFieldSpecified;
        
        private double designedDistanceReferencePointSpherePowerField;
        
        private bool designedDistanceReferencePointSpherePowerFieldSpecified;
        
        private int designedLayoutReferencePointCylinderAxisField;
        
        private bool designedLayoutReferencePointCylinderAxisFieldSpecified;
        
        private double designedLayoutReferencePointCylinderPowerField;
        
        private bool designedLayoutReferencePointCylinderPowerFieldSpecified;
        
        private double designedLayoutReferencePointSpherePowerField;
        
        private bool designedLayoutReferencePointSpherePowerFieldSpecified;
        
        private int designedNearReferencePointCylinderAxisField;
        
        private bool designedNearReferencePointCylinderAxisFieldSpecified;
        
        private double designedNearReferencePointCylinderPowerField;
        
        private bool designedNearReferencePointCylinderPowerFieldSpecified;
        
        private double designedNearReferencePointSpherePowerField;
        
        private bool designedNearReferencePointSpherePowerFieldSpecified;
        
        private int designedPrismBaseSettingField;
        
        private bool designedPrismBaseSettingFieldSpecified;
        
        private double designedPrismMagnitudeField;
        
        private bool designedPrismMagnitudeFieldSpecified;
        
        private double finishedCenterThicknessField;
        
        private bool finishedCenterThicknessFieldSpecified;
        
        private double lapBaseCurveField;
        
        private bool lapBaseCurveFieldSpecified;
        
        private double lapCrossCurveField;
        
        private bool lapCrossCurveFieldSpecified;
        
        private double surfaceBlockCenterGeneratorThicknessField;
        
        private bool surfaceBlockCenterGeneratorThicknessFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int cribPerimeterThickestPointAngle
        {
            get
            {
                return this.cribPerimeterThickestPointAngleField;
            }
            set
            {
                this.cribPerimeterThickestPointAngleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cribPerimeterThickestPointAngleSpecified
        {
            get
            {
                return this.cribPerimeterThickestPointAngleFieldSpecified;
            }
            set
            {
                this.cribPerimeterThickestPointAngleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public double cribPerimeterThickestPointThickness
        {
            get
            {
                return this.cribPerimeterThickestPointThicknessField;
            }
            set
            {
                this.cribPerimeterThickestPointThicknessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cribPerimeterThickestPointThicknessSpecified
        {
            get
            {
                return this.cribPerimeterThickestPointThicknessFieldSpecified;
            }
            set
            {
                this.cribPerimeterThickestPointThicknessFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int cribPerimeterThinnestPointAngle
        {
            get
            {
                return this.cribPerimeterThinnestPointAngleField;
            }
            set
            {
                this.cribPerimeterThinnestPointAngleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cribPerimeterThinnestPointAngleSpecified
        {
            get
            {
                return this.cribPerimeterThinnestPointAngleFieldSpecified;
            }
            set
            {
                this.cribPerimeterThinnestPointAngleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public double cribPerimeterThinnestPointThickness
        {
            get
            {
                return this.cribPerimeterThinnestPointThicknessField;
            }
            set
            {
                this.cribPerimeterThinnestPointThicknessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cribPerimeterThinnestPointThicknessSpecified
        {
            get
            {
                return this.cribPerimeterThinnestPointThicknessFieldSpecified;
            }
            set
            {
                this.cribPerimeterThinnestPointThicknessFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public double designedAdditionPower
        {
            get
            {
                return this.designedAdditionPowerField;
            }
            set
            {
                this.designedAdditionPowerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool designedAdditionPowerSpecified
        {
            get
            {
                return this.designedAdditionPowerFieldSpecified;
            }
            set
            {
                this.designedAdditionPowerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int designedDistanceReferencePointCylinderAxis
        {
            get
            {
                return this.designedDistanceReferencePointCylinderAxisField;
            }
            set
            {
                this.designedDistanceReferencePointCylinderAxisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool designedDistanceReferencePointCylinderAxisSpecified
        {
            get
            {
                return this.designedDistanceReferencePointCylinderAxisFieldSpecified;
            }
            set
            {
                this.designedDistanceReferencePointCylinderAxisFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public double designedDistanceReferencePointCylinderPower
        {
            get
            {
                return this.designedDistanceReferencePointCylinderPowerField;
            }
            set
            {
                this.designedDistanceReferencePointCylinderPowerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool designedDistanceReferencePointCylinderPowerSpecified
        {
            get
            {
                return this.designedDistanceReferencePointCylinderPowerFieldSpecified;
            }
            set
            {
                this.designedDistanceReferencePointCylinderPowerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public double designedDistanceReferencePointSpherePower
        {
            get
            {
                return this.designedDistanceReferencePointSpherePowerField;
            }
            set
            {
                this.designedDistanceReferencePointSpherePowerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool designedDistanceReferencePointSpherePowerSpecified
        {
            get
            {
                return this.designedDistanceReferencePointSpherePowerFieldSpecified;
            }
            set
            {
                this.designedDistanceReferencePointSpherePowerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public int designedLayoutReferencePointCylinderAxis
        {
            get
            {
                return this.designedLayoutReferencePointCylinderAxisField;
            }
            set
            {
                this.designedLayoutReferencePointCylinderAxisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool designedLayoutReferencePointCylinderAxisSpecified
        {
            get
            {
                return this.designedLayoutReferencePointCylinderAxisFieldSpecified;
            }
            set
            {
                this.designedLayoutReferencePointCylinderAxisFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public double designedLayoutReferencePointCylinderPower
        {
            get
            {
                return this.designedLayoutReferencePointCylinderPowerField;
            }
            set
            {
                this.designedLayoutReferencePointCylinderPowerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool designedLayoutReferencePointCylinderPowerSpecified
        {
            get
            {
                return this.designedLayoutReferencePointCylinderPowerFieldSpecified;
            }
            set
            {
                this.designedLayoutReferencePointCylinderPowerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public double designedLayoutReferencePointSpherePower
        {
            get
            {
                return this.designedLayoutReferencePointSpherePowerField;
            }
            set
            {
                this.designedLayoutReferencePointSpherePowerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool designedLayoutReferencePointSpherePowerSpecified
        {
            get
            {
                return this.designedLayoutReferencePointSpherePowerFieldSpecified;
            }
            set
            {
                this.designedLayoutReferencePointSpherePowerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public int designedNearReferencePointCylinderAxis
        {
            get
            {
                return this.designedNearReferencePointCylinderAxisField;
            }
            set
            {
                this.designedNearReferencePointCylinderAxisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool designedNearReferencePointCylinderAxisSpecified
        {
            get
            {
                return this.designedNearReferencePointCylinderAxisFieldSpecified;
            }
            set
            {
                this.designedNearReferencePointCylinderAxisFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public double designedNearReferencePointCylinderPower
        {
            get
            {
                return this.designedNearReferencePointCylinderPowerField;
            }
            set
            {
                this.designedNearReferencePointCylinderPowerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool designedNearReferencePointCylinderPowerSpecified
        {
            get
            {
                return this.designedNearReferencePointCylinderPowerFieldSpecified;
            }
            set
            {
                this.designedNearReferencePointCylinderPowerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public double designedNearReferencePointSpherePower
        {
            get
            {
                return this.designedNearReferencePointSpherePowerField;
            }
            set
            {
                this.designedNearReferencePointSpherePowerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool designedNearReferencePointSpherePowerSpecified
        {
            get
            {
                return this.designedNearReferencePointSpherePowerFieldSpecified;
            }
            set
            {
                this.designedNearReferencePointSpherePowerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public int designedPrismBaseSetting
        {
            get
            {
                return this.designedPrismBaseSettingField;
            }
            set
            {
                this.designedPrismBaseSettingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool designedPrismBaseSettingSpecified
        {
            get
            {
                return this.designedPrismBaseSettingFieldSpecified;
            }
            set
            {
                this.designedPrismBaseSettingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public double designedPrismMagnitude
        {
            get
            {
                return this.designedPrismMagnitudeField;
            }
            set
            {
                this.designedPrismMagnitudeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool designedPrismMagnitudeSpecified
        {
            get
            {
                return this.designedPrismMagnitudeFieldSpecified;
            }
            set
            {
                this.designedPrismMagnitudeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public double finishedCenterThickness
        {
            get
            {
                return this.finishedCenterThicknessField;
            }
            set
            {
                this.finishedCenterThicknessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool finishedCenterThicknessSpecified
        {
            get
            {
                return this.finishedCenterThicknessFieldSpecified;
            }
            set
            {
                this.finishedCenterThicknessFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public double lapBaseCurve
        {
            get
            {
                return this.lapBaseCurveField;
            }
            set
            {
                this.lapBaseCurveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lapBaseCurveSpecified
        {
            get
            {
                return this.lapBaseCurveFieldSpecified;
            }
            set
            {
                this.lapBaseCurveFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public double lapCrossCurve
        {
            get
            {
                return this.lapCrossCurveField;
            }
            set
            {
                this.lapCrossCurveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lapCrossCurveSpecified
        {
            get
            {
                return this.lapCrossCurveFieldSpecified;
            }
            set
            {
                this.lapCrossCurveFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=19)]
        public double surfaceBlockCenterGeneratorThickness
        {
            get
            {
                return this.surfaceBlockCenterGeneratorThicknessField;
            }
            set
            {
                this.surfaceBlockCenterGeneratorThicknessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool surfaceBlockCenterGeneratorThicknessSpecified
        {
            get
            {
                return this.surfaceBlockCenterGeneratorThicknessFieldSpecified;
            }
            set
            {
                this.surfaceBlockCenterGeneratorThicknessFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computeLensResponseSideDTO : computeLensResponseOmaSideDTO
    {
        
        private double crossPositionField;
        
        private bool crossPositionFieldSpecified;
        
        private double downsetField;
        
        private bool downsetFieldSpecified;
        
        private double insetField;
        
        private bool insetFieldSpecified;
        
        private threeDimensionalPointDTO[] pointsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public double crossPosition
        {
            get
            {
                return this.crossPositionField;
            }
            set
            {
                this.crossPositionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool crossPositionSpecified
        {
            get
            {
                return this.crossPositionFieldSpecified;
            }
            set
            {
                this.crossPositionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public double downset
        {
            get
            {
                return this.downsetField;
            }
            set
            {
                this.downsetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool downsetSpecified
        {
            get
            {
                return this.downsetFieldSpecified;
            }
            set
            {
                this.downsetFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public double inset
        {
            get
            {
                return this.insetField;
            }
            set
            {
                this.insetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool insetSpecified
        {
            get
            {
                return this.insetFieldSpecified;
            }
            set
            {
                this.insetFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("points", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=3)]
        public threeDimensionalPointDTO[] points
        {
            get
            {
                return this.pointsField;
            }
            set
            {
                this.pointsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeLensRequestSideDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computeLensRequestOmaSideDTO
    {
        
        private double addictionField;
        
        private bool addictionFieldSpecified;
        
        private double cylinderField;
        
        private bool cylinderFieldSpecified;
        
        private int cylinderAxisField;
        
        private bool cylinderAxisFieldSpecified;
        
        private int horizontalDiameterField;
        
        private bool horizontalDiameterFieldSpecified;
        
        private double minimalCentralThicknessField;
        
        private bool minimalCentralThicknessFieldSpecified;
        
        private double minimalHoleThicknessField;
        
        private bool minimalHoleThicknessFieldSpecified;
        
        private double minimalSideThicknessField;
        
        private bool minimalSideThicknessFieldSpecified;
        
        private double monocularCentrationDistanceField;
        
        private bool monocularCentrationDistanceFieldSpecified;
        
        private double prescriptedPrismField;
        
        private bool prescriptedPrismFieldSpecified;
        
        private int prescriptedPrismBaseField;
        
        private bool prescriptedPrismBaseFieldSpecified;
        
        private double refractiveIndexField;
        
        private bool refractiveIndexFieldSpecified;
        
        private side sideField;
        
        private bool sideFieldSpecified;
        
        private double sphereField;
        
        private bool sphereFieldSpecified;
        
        private double toolIndexField;
        
        private bool toolIndexFieldSpecified;
        
        private double toolRealBaseField;
        
        private bool toolRealBaseFieldSpecified;
        
        private int verticalDiameterField;
        
        private bool verticalDiameterFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public double addiction
        {
            get
            {
                return this.addictionField;
            }
            set
            {
                this.addictionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool addictionSpecified
        {
            get
            {
                return this.addictionFieldSpecified;
            }
            set
            {
                this.addictionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public double cylinder
        {
            get
            {
                return this.cylinderField;
            }
            set
            {
                this.cylinderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cylinderSpecified
        {
            get
            {
                return this.cylinderFieldSpecified;
            }
            set
            {
                this.cylinderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int cylinderAxis
        {
            get
            {
                return this.cylinderAxisField;
            }
            set
            {
                this.cylinderAxisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cylinderAxisSpecified
        {
            get
            {
                return this.cylinderAxisFieldSpecified;
            }
            set
            {
                this.cylinderAxisFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int horizontalDiameter
        {
            get
            {
                return this.horizontalDiameterField;
            }
            set
            {
                this.horizontalDiameterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horizontalDiameterSpecified
        {
            get
            {
                return this.horizontalDiameterFieldSpecified;
            }
            set
            {
                this.horizontalDiameterFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public double minimalCentralThickness
        {
            get
            {
                return this.minimalCentralThicknessField;
            }
            set
            {
                this.minimalCentralThicknessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minimalCentralThicknessSpecified
        {
            get
            {
                return this.minimalCentralThicknessFieldSpecified;
            }
            set
            {
                this.minimalCentralThicknessFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public double minimalHoleThickness
        {
            get
            {
                return this.minimalHoleThicknessField;
            }
            set
            {
                this.minimalHoleThicknessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minimalHoleThicknessSpecified
        {
            get
            {
                return this.minimalHoleThicknessFieldSpecified;
            }
            set
            {
                this.minimalHoleThicknessFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public double minimalSideThickness
        {
            get
            {
                return this.minimalSideThicknessField;
            }
            set
            {
                this.minimalSideThicknessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minimalSideThicknessSpecified
        {
            get
            {
                return this.minimalSideThicknessFieldSpecified;
            }
            set
            {
                this.minimalSideThicknessFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public double monocularCentrationDistance
        {
            get
            {
                return this.monocularCentrationDistanceField;
            }
            set
            {
                this.monocularCentrationDistanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool monocularCentrationDistanceSpecified
        {
            get
            {
                return this.monocularCentrationDistanceFieldSpecified;
            }
            set
            {
                this.monocularCentrationDistanceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public double prescriptedPrism
        {
            get
            {
                return this.prescriptedPrismField;
            }
            set
            {
                this.prescriptedPrismField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool prescriptedPrismSpecified
        {
            get
            {
                return this.prescriptedPrismFieldSpecified;
            }
            set
            {
                this.prescriptedPrismFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public int prescriptedPrismBase
        {
            get
            {
                return this.prescriptedPrismBaseField;
            }
            set
            {
                this.prescriptedPrismBaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool prescriptedPrismBaseSpecified
        {
            get
            {
                return this.prescriptedPrismBaseFieldSpecified;
            }
            set
            {
                this.prescriptedPrismBaseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public double refractiveIndex
        {
            get
            {
                return this.refractiveIndexField;
            }
            set
            {
                this.refractiveIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool refractiveIndexSpecified
        {
            get
            {
                return this.refractiveIndexFieldSpecified;
            }
            set
            {
                this.refractiveIndexFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public side side
        {
            get
            {
                return this.sideField;
            }
            set
            {
                this.sideField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sideSpecified
        {
            get
            {
                return this.sideFieldSpecified;
            }
            set
            {
                this.sideFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public double sphere
        {
            get
            {
                return this.sphereField;
            }
            set
            {
                this.sphereField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sphereSpecified
        {
            get
            {
                return this.sphereFieldSpecified;
            }
            set
            {
                this.sphereFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public double toolIndex
        {
            get
            {
                return this.toolIndexField;
            }
            set
            {
                this.toolIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool toolIndexSpecified
        {
            get
            {
                return this.toolIndexFieldSpecified;
            }
            set
            {
                this.toolIndexFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public double toolRealBase
        {
            get
            {
                return this.toolRealBaseField;
            }
            set
            {
                this.toolRealBaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool toolRealBaseSpecified
        {
            get
            {
                return this.toolRealBaseFieldSpecified;
            }
            set
            {
                this.toolRealBaseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public int verticalDiameter
        {
            get
            {
                return this.verticalDiameterField;
            }
            set
            {
                this.verticalDiameterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool verticalDiameterSpecified
        {
            get
            {
                return this.verticalDiameterFieldSpecified;
            }
            set
            {
                this.verticalDiameterFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public enum side
    {
        
        /// <remarks/>
        LEFT,
        
        /// <remarks/>
        RIGHT,
        
        /// <remarks/>
        UNKNOWN,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computeLensRequestSideDTO : computeLensRequestOmaSideDTO
    {
        
        private double holeXField;
        
        private bool holeXFieldSpecified;
        
        private double holeYField;
        
        private bool holeYFieldSpecified;
        
        private double horizontalDecentralizationField;
        
        private bool horizontalDecentralizationFieldSpecified;
        
        private double insetField;
        
        private bool insetFieldSpecified;
        
        private double minimalShapeThicknessField;
        
        private bool minimalShapeThicknessFieldSpecified;
        
        private double secondaryPrismField;
        
        private bool secondaryPrismFieldSpecified;
        
        private int secondaryPrismBaseField;
        
        private bool secondaryPrismBaseFieldSpecified;
        
        private double verticalDecentralizationField;
        
        private bool verticalDecentralizationFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public double holeX
        {
            get
            {
                return this.holeXField;
            }
            set
            {
                this.holeXField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool holeXSpecified
        {
            get
            {
                return this.holeXFieldSpecified;
            }
            set
            {
                this.holeXFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public double holeY
        {
            get
            {
                return this.holeYField;
            }
            set
            {
                this.holeYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool holeYSpecified
        {
            get
            {
                return this.holeYFieldSpecified;
            }
            set
            {
                this.holeYFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public double horizontalDecentralization
        {
            get
            {
                return this.horizontalDecentralizationField;
            }
            set
            {
                this.horizontalDecentralizationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horizontalDecentralizationSpecified
        {
            get
            {
                return this.horizontalDecentralizationFieldSpecified;
            }
            set
            {
                this.horizontalDecentralizationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public double inset
        {
            get
            {
                return this.insetField;
            }
            set
            {
                this.insetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool insetSpecified
        {
            get
            {
                return this.insetFieldSpecified;
            }
            set
            {
                this.insetFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public double minimalShapeThickness
        {
            get
            {
                return this.minimalShapeThicknessField;
            }
            set
            {
                this.minimalShapeThicknessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minimalShapeThicknessSpecified
        {
            get
            {
                return this.minimalShapeThicknessFieldSpecified;
            }
            set
            {
                this.minimalShapeThicknessFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public double secondaryPrism
        {
            get
            {
                return this.secondaryPrismField;
            }
            set
            {
                this.secondaryPrismField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool secondaryPrismSpecified
        {
            get
            {
                return this.secondaryPrismFieldSpecified;
            }
            set
            {
                this.secondaryPrismFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int secondaryPrismBase
        {
            get
            {
                return this.secondaryPrismBaseField;
            }
            set
            {
                this.secondaryPrismBaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool secondaryPrismBaseSpecified
        {
            get
            {
                return this.secondaryPrismBaseFieldSpecified;
            }
            set
            {
                this.secondaryPrismBaseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public double verticalDecentralization
        {
            get
            {
                return this.verticalDecentralizationField;
            }
            set
            {
                this.verticalDecentralizationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool verticalDecentralizationSpecified
        {
            get
            {
                return this.verticalDecentralizationFieldSpecified;
            }
            set
            {
                this.verticalDecentralizationFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(responseDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeResponseDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeLensResponseDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(analyzeLensResponseDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(requestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(analyzeLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeAcquiredLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeOfficeLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(compute4K13LensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(compute4K09LensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(compute4K11LensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeEblRegularLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeEblUltraShortLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(compute4K07LensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeAntifatigueLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeFantasyLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeEblExtraShortLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeEblShortLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeBasicLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeMagicLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeNativeLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeComposedLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeAestheticLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computePunctualLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeMonofLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeNearLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeIprogLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeIprofLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeFarLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeDigitLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeVarioLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeIflexLensRequestDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public abstract partial class messageDTO
    {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeResponseDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeLensResponseDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(analyzeLensResponseDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public abstract partial class responseDTO : messageDTO
    {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeLensResponseDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(analyzeLensResponseDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public abstract partial class computeResponseDTO : responseDTO
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computeLensResponseDTO : computeResponseDTO
    {
        
        private computeLensResponseSideDTO valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public computeLensResponseSideDTO value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class analyzeLensResponseDTO : computeResponseDTO
    {
        
        private analyzedPointDTO[] pointsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("points", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=0)]
        public analyzedPointDTO[] points
        {
            get
            {
                return this.pointsField;
            }
            set
            {
                this.pointsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class analyzedPointDTO : threeDimensionalPointDTO
    {
        
        private double cylinderAxisField;
        
        private bool cylinderAxisFieldSpecified;
        
        private double cylinderMapField;
        
        private bool cylinderMapFieldSpecified;
        
        private double powerAxisField;
        
        private bool powerAxisFieldSpecified;
        
        private double powerMapField;
        
        private bool powerMapFieldSpecified;
        
        private double thicknessField;
        
        private bool thicknessFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public double cylinderAxis
        {
            get
            {
                return this.cylinderAxisField;
            }
            set
            {
                this.cylinderAxisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cylinderAxisSpecified
        {
            get
            {
                return this.cylinderAxisFieldSpecified;
            }
            set
            {
                this.cylinderAxisFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public double cylinderMap
        {
            get
            {
                return this.cylinderMapField;
            }
            set
            {
                this.cylinderMapField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cylinderMapSpecified
        {
            get
            {
                return this.cylinderMapFieldSpecified;
            }
            set
            {
                this.cylinderMapFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public double powerAxis
        {
            get
            {
                return this.powerAxisField;
            }
            set
            {
                this.powerAxisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool powerAxisSpecified
        {
            get
            {
                return this.powerAxisFieldSpecified;
            }
            set
            {
                this.powerAxisFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public double powerMap
        {
            get
            {
                return this.powerMapField;
            }
            set
            {
                this.powerMapField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool powerMapSpecified
        {
            get
            {
                return this.powerMapFieldSpecified;
            }
            set
            {
                this.powerMapFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public double thickness
        {
            get
            {
                return this.thicknessField;
            }
            set
            {
                this.thicknessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool thicknessSpecified
        {
            get
            {
                return this.thicknessFieldSpecified;
            }
            set
            {
                this.thicknessFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(analyzeLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeAcquiredLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeOfficeLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(compute4K13LensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(compute4K09LensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(compute4K11LensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeEblRegularLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeEblUltraShortLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(compute4K07LensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeAntifatigueLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeFantasyLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeEblExtraShortLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeEblShortLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeBasicLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeMagicLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeNativeLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeComposedLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeAestheticLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computePunctualLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeMonofLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeNearLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeIprogLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeIprofLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeFarLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeDigitLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeVarioLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeIflexLensRequestDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public abstract partial class requestDTO : messageDTO
    {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(analyzeLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeAcquiredLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeOfficeLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(compute4K13LensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(compute4K09LensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(compute4K11LensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeEblRegularLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeEblUltraShortLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(compute4K07LensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeAntifatigueLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeFantasyLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeEblExtraShortLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeEblShortLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeBasicLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeMagicLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeNativeLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeComposedLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeAestheticLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computePunctualLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeMonofLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeNearLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeIprogLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeIprofLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeFarLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeDigitLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeVarioLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeIflexLensRequestDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public abstract partial class computeRequestDTO : requestDTO
    {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeAcquiredLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeOfficeLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(compute4K13LensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(compute4K09LensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(compute4K11LensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeEblRegularLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeEblUltraShortLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(compute4K07LensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeAntifatigueLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeFantasyLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeEblExtraShortLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeEblShortLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeBasicLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeMagicLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeNativeLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeComposedLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeAestheticLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computePunctualLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeMonofLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeNearLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeIprogLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeIprofLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeFarLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeDigitLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeVarioLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeIflexLensRequestDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public abstract partial class computeLensRequestDTO : computeRequestDTO
    {
        
        private bool atoricField;
        
        private bool atoricFieldSpecified;
        
        private double backVertexDistanceField;
        
        private bool backVertexDistanceFieldSpecified;
        
        private double eyeDiameterField;
        
        private bool eyeDiameterFieldSpecified;
        
        private bool horizontalPrismThinningField;
        
        private bool horizontalPrismThinningFieldSpecified;
        
        private double horizontalPrismThinningHeightField;
        
        private bool horizontalPrismThinningHeightFieldSpecified;
        
        private double maximumPrismThinningCompensationField;
        
        private bool maximumPrismThinningCompensationFieldSpecified;
        
        private double pantoscopicAngleField;
        
        private bool pantoscopicAngleFieldSpecified;
        
        private bool prismThinningCompensationField;
        
        private bool prismThinningCompensationFieldSpecified;
        
        private double readDistanceField;
        
        private bool readDistanceFieldSpecified;
        
        private computeLensRequestSideDTO valueField;
        
        private bool verticalPrismThinningField;
        
        private bool verticalPrismThinningFieldSpecified;
        
        private double wrappingAngleField;
        
        private bool wrappingAngleFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool atoric
        {
            get
            {
                return this.atoricField;
            }
            set
            {
                this.atoricField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool atoricSpecified
        {
            get
            {
                return this.atoricFieldSpecified;
            }
            set
            {
                this.atoricFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public double backVertexDistance
        {
            get
            {
                return this.backVertexDistanceField;
            }
            set
            {
                this.backVertexDistanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool backVertexDistanceSpecified
        {
            get
            {
                return this.backVertexDistanceFieldSpecified;
            }
            set
            {
                this.backVertexDistanceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public double eyeDiameter
        {
            get
            {
                return this.eyeDiameterField;
            }
            set
            {
                this.eyeDiameterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eyeDiameterSpecified
        {
            get
            {
                return this.eyeDiameterFieldSpecified;
            }
            set
            {
                this.eyeDiameterFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public bool horizontalPrismThinning
        {
            get
            {
                return this.horizontalPrismThinningField;
            }
            set
            {
                this.horizontalPrismThinningField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horizontalPrismThinningSpecified
        {
            get
            {
                return this.horizontalPrismThinningFieldSpecified;
            }
            set
            {
                this.horizontalPrismThinningFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public double horizontalPrismThinningHeight
        {
            get
            {
                return this.horizontalPrismThinningHeightField;
            }
            set
            {
                this.horizontalPrismThinningHeightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horizontalPrismThinningHeightSpecified
        {
            get
            {
                return this.horizontalPrismThinningHeightFieldSpecified;
            }
            set
            {
                this.horizontalPrismThinningHeightFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public double maximumPrismThinningCompensation
        {
            get
            {
                return this.maximumPrismThinningCompensationField;
            }
            set
            {
                this.maximumPrismThinningCompensationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumPrismThinningCompensationSpecified
        {
            get
            {
                return this.maximumPrismThinningCompensationFieldSpecified;
            }
            set
            {
                this.maximumPrismThinningCompensationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public double pantoscopicAngle
        {
            get
            {
                return this.pantoscopicAngleField;
            }
            set
            {
                this.pantoscopicAngleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pantoscopicAngleSpecified
        {
            get
            {
                return this.pantoscopicAngleFieldSpecified;
            }
            set
            {
                this.pantoscopicAngleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public bool prismThinningCompensation
        {
            get
            {
                return this.prismThinningCompensationField;
            }
            set
            {
                this.prismThinningCompensationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool prismThinningCompensationSpecified
        {
            get
            {
                return this.prismThinningCompensationFieldSpecified;
            }
            set
            {
                this.prismThinningCompensationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public double readDistance
        {
            get
            {
                return this.readDistanceField;
            }
            set
            {
                this.readDistanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool readDistanceSpecified
        {
            get
            {
                return this.readDistanceFieldSpecified;
            }
            set
            {
                this.readDistanceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public computeLensRequestSideDTO value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public bool verticalPrismThinning
        {
            get
            {
                return this.verticalPrismThinningField;
            }
            set
            {
                this.verticalPrismThinningField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool verticalPrismThinningSpecified
        {
            get
            {
                return this.verticalPrismThinningFieldSpecified;
            }
            set
            {
                this.verticalPrismThinningFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public double wrappingAngle
        {
            get
            {
                return this.wrappingAngleField;
            }
            set
            {
                this.wrappingAngleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool wrappingAngleSpecified
        {
            get
            {
                return this.wrappingAngleFieldSpecified;
            }
            set
            {
                this.wrappingAngleFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeOfficeLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(compute4K13LensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(compute4K09LensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(compute4K11LensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeEblRegularLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeEblUltraShortLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(compute4K07LensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeAntifatigueLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeFantasyLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeEblExtraShortLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeEblShortLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeBasicLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeMagicLensRequestDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public abstract partial class computeAcquiredLensRequestDTO : computeLensRequestDTO
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computeOfficeLensRequestDTO : computeAcquiredLensRequestDTO
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class compute4K13LensRequestDTO : computeAcquiredLensRequestDTO
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class compute4K09LensRequestDTO : computeAcquiredLensRequestDTO
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class compute4K11LensRequestDTO : computeAcquiredLensRequestDTO
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computeEblRegularLensRequestDTO : computeAcquiredLensRequestDTO
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computeEblUltraShortLensRequestDTO : computeAcquiredLensRequestDTO
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class compute4K07LensRequestDTO : computeAcquiredLensRequestDTO
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computeAntifatigueLensRequestDTO : computeAcquiredLensRequestDTO
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computeFantasyLensRequestDTO : computeAcquiredLensRequestDTO
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computeEblExtraShortLensRequestDTO : computeAcquiredLensRequestDTO
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computeEblShortLensRequestDTO : computeAcquiredLensRequestDTO
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computeBasicLensRequestDTO : computeAcquiredLensRequestDTO
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computeMagicLensRequestDTO : computeAcquiredLensRequestDTO
    {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeComposedLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeAestheticLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computePunctualLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeMonofLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeNearLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeIprogLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeIprofLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeFarLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeDigitLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeVarioLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeIflexLensRequestDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public abstract partial class computeNativeLensRequestDTO : computeLensRequestDTO
    {
        
        private int channelField;
        
        private bool channelFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int channel
        {
            get
            {
                return this.channelField;
            }
            set
            {
                this.channelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool channelSpecified
        {
            get
            {
                return this.channelFieldSpecified;
            }
            set
            {
                this.channelFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeAestheticLensRequestDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public abstract partial class computeComposedLensRequestDTO : computeNativeLensRequestDTO
    {
        
        private double approximationFactorField;
        
        private bool approximationFactorFieldSpecified;
        
        private computeLensRequestDTO componentLensRequestField;
        
        private int internalLensDiameterField;
        
        private bool internalLensDiameterFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public double approximationFactor
        {
            get
            {
                return this.approximationFactorField;
            }
            set
            {
                this.approximationFactorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool approximationFactorSpecified
        {
            get
            {
                return this.approximationFactorFieldSpecified;
            }
            set
            {
                this.approximationFactorFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public computeLensRequestDTO componentLensRequest
        {
            get
            {
                return this.componentLensRequestField;
            }
            set
            {
                this.componentLensRequestField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int internalLensDiameter
        {
            get
            {
                return this.internalLensDiameterField;
            }
            set
            {
                this.internalLensDiameterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool internalLensDiameterSpecified
        {
            get
            {
                return this.internalLensDiameterFieldSpecified;
            }
            set
            {
                this.internalLensDiameterFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computeAestheticLensRequestDTO : computeComposedLensRequestDTO
    {
        
        private int junctionDiameterField;
        
        private bool junctionDiameterFieldSpecified;
        
        private int sideAngleField;
        
        private bool sideAngleFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int junctionDiameter
        {
            get
            {
                return this.junctionDiameterField;
            }
            set
            {
                this.junctionDiameterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool junctionDiameterSpecified
        {
            get
            {
                return this.junctionDiameterFieldSpecified;
            }
            set
            {
                this.junctionDiameterFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int sideAngle
        {
            get
            {
                return this.sideAngleField;
            }
            set
            {
                this.sideAngleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sideAngleSpecified
        {
            get
            {
                return this.sideAngleFieldSpecified;
            }
            set
            {
                this.sideAngleFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computePunctualLensRequestDTO : computeNativeLensRequestDTO
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computeMonofLensRequestDTO : computeNativeLensRequestDTO
    {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeIprogLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeIprofLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeFarLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeDigitLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeVarioLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeIflexLensRequestDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public abstract partial class computeNearLensRequestDTO : computeNativeLensRequestDTO
    {
        
        private int nearField;
        
        private bool nearFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int near
        {
            get
            {
                return this.nearField;
            }
            set
            {
                this.nearField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nearSpecified
        {
            get
            {
                return this.nearFieldSpecified;
            }
            set
            {
                this.nearFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computeIprogLensRequestDTO : computeNearLensRequestDTO
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computeIprofLensRequestDTO : computeNearLensRequestDTO
    {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeDigitLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeVarioLensRequestDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(computeIflexLensRequestDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public abstract partial class computeFarLensRequestDTO : computeNearLensRequestDTO
    {
        
        private int farField;
        
        private bool farFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int far
        {
            get
            {
                return this.farField;
            }
            set
            {
                this.farField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool farSpecified
        {
            get
            {
                return this.farFieldSpecified;
            }
            set
            {
                this.farFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computeDigitLensRequestDTO : computeFarLensRequestDTO
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computeVarioLensRequestDTO : computeFarLensRequestDTO
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class computeIflexLensRequestDTO : computeFarLensRequestDTO
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="analyzeLens", WrapperNamespace="http://soap.service.optoplus.visiontech.org/", IsWrapped=true)]
    public partial class analyzeLens
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.service.optoplus.visiontech.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Org.Visiontech.Compute.analyzeLensRequestDTO arg0;
        
        public analyzeLens()
        {
        }
        
        public analyzeLens(Org.Visiontech.Compute.analyzeLensRequestDTO arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="analyzeLensResponse", WrapperNamespace="http://soap.service.optoplus.visiontech.org/", IsWrapped=true)]
    public partial class analyzeLensResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.service.optoplus.visiontech.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Org.Visiontech.Compute.analyzeLensResponseDTO @return;
        
        public analyzeLensResponse()
        {
        }
        
        public analyzeLensResponse(Org.Visiontech.Compute.analyzeLensResponseDTO @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="computeLens", WrapperNamespace="http://soap.service.optoplus.visiontech.org/", IsWrapped=true)]
    public partial class computeLens
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.service.optoplus.visiontech.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Org.Visiontech.Compute.computeLensRequestDTO arg0;
        
        public computeLens()
        {
        }
        
        public computeLens(Org.Visiontech.Compute.computeLensRequestDTO arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="computeLensResponse", WrapperNamespace="http://soap.service.optoplus.visiontech.org/", IsWrapped=true)]
    public partial class computeLensResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.service.optoplus.visiontech.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Org.Visiontech.Compute.computeLensResponseDTO @return;
        
        public computeLensResponse()
        {
        }
        
        public computeLensResponse(Org.Visiontech.Compute.computeLensResponseDTO @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="previewLens", WrapperNamespace="http://soap.service.optoplus.visiontech.org/", IsWrapped=true)]
    public partial class previewLens
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.service.optoplus.visiontech.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Org.Visiontech.Compute.computeLensRequestDTO arg0;
        
        public previewLens()
        {
        }
        
        public previewLens(Org.Visiontech.Compute.computeLensRequestDTO arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="previewLensResponse", WrapperNamespace="http://soap.service.optoplus.visiontech.org/", IsWrapped=true)]
    public partial class previewLensResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.service.optoplus.visiontech.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Org.Visiontech.Compute.computeLensResponseDTO @return;
        
        public previewLensResponse()
        {
        }
        
        public previewLensResponse(Org.Visiontech.Compute.computeLensResponseDTO @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface ComputeSoapChannel : Org.Visiontech.Compute.ComputeSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class ComputeSoapClient : System.ServiceModel.ClientBase<Org.Visiontech.Compute.ComputeSoap>, Org.Visiontech.Compute.ComputeSoap
    {
        
    /// <summary>
    /// Implementare questo metodo parziale per configurare l'endpoint servizio.
    /// </summary>
    /// <param name="serviceEndpoint">Endpoint da configurare</param>
    /// <param name="clientCredentials">Credenziali del client</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ComputeSoapClient() : 
                base(ComputeSoapClient.GetDefaultBinding(), ComputeSoapClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.ComputeSoapPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ComputeSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(ComputeSoapClient.GetBindingForEndpoint(endpointConfiguration), ComputeSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ComputeSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ComputeSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ComputeSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ComputeSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ComputeSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Org.Visiontech.Compute.analyzeLensResponse> Org.Visiontech.Compute.ComputeSoap.analyzeLensAsync(Org.Visiontech.Compute.analyzeLens request)
        {
            return base.Channel.analyzeLensAsync(request);
        }
        
        public System.Threading.Tasks.Task<Org.Visiontech.Compute.analyzeLensResponse> analyzeLensAsync(Org.Visiontech.Compute.analyzeLensRequestDTO arg0)
        {
            Org.Visiontech.Compute.analyzeLens inValue = new Org.Visiontech.Compute.analyzeLens();
            inValue.arg0 = arg0;
            return ((Org.Visiontech.Compute.ComputeSoap)(this)).analyzeLensAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Org.Visiontech.Compute.computeLensResponse> Org.Visiontech.Compute.ComputeSoap.computeLensAsync(Org.Visiontech.Compute.computeLens request)
        {
            return base.Channel.computeLensAsync(request);
        }
        
        public System.Threading.Tasks.Task<Org.Visiontech.Compute.computeLensResponse> computeLensAsync(Org.Visiontech.Compute.computeLensRequestDTO arg0)
        {
            Org.Visiontech.Compute.computeLens inValue = new Org.Visiontech.Compute.computeLens();
            inValue.arg0 = arg0;
            return ((Org.Visiontech.Compute.ComputeSoap)(this)).computeLensAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Org.Visiontech.Compute.previewLensResponse> Org.Visiontech.Compute.ComputeSoap.previewLensAsync(Org.Visiontech.Compute.previewLens request)
        {
            return base.Channel.previewLensAsync(request);
        }
        
        public System.Threading.Tasks.Task<Org.Visiontech.Compute.previewLensResponse> previewLensAsync(Org.Visiontech.Compute.computeLensRequestDTO arg0)
        {
            Org.Visiontech.Compute.previewLens inValue = new Org.Visiontech.Compute.previewLens();
            inValue.arg0 = arg0;
            return ((Org.Visiontech.Compute.ComputeSoap)(this)).previewLensAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ComputeSoapPort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("L\'endpoint denominato \'{0}\' non è stato trovato.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ComputeSoapPort))
            {
                return new System.ServiceModel.EndpointAddress("http://172.17.0.2:8080/optoplus-services-web/ComputeSoap");
            }
            throw new System.InvalidOperationException(string.Format("L\'endpoint denominato \'{0}\' non è stato trovato.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ComputeSoapClient.GetBindingForEndpoint(EndpointConfiguration.ComputeSoapPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ComputeSoapClient.GetEndpointAddress(EndpointConfiguration.ComputeSoapPort);
        }
        
        public enum EndpointConfiguration
        {
            
            ComputeSoapPort,
        }
    }
}
