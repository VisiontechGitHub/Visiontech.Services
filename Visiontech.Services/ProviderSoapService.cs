﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Org.Visiontech.Provider
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://soap.service.optoplus.visiontech.org/", ConfigurationName="Org.Visiontech.Provider.ProviderSoap")]
    public interface ProviderSoap
    {
        
        // CODEGEN: Il parametro 'arg0' richiede informazioni sullo schema aggiuntive che non possono essere acquisite utilizzando la modalità parametro. L'attributo specifico è 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(jsonbPolimorphic))]
        Org.Visiontech.Provider.deleteResponse delete(Org.Visiontech.Provider.delete request);
        
        // CODEGEN: Il parametro 'return' richiede informazioni sullo schema aggiuntive che non possono essere acquisite utilizzando la modalità parametro. L'attributo specifico è 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(jsonbPolimorphic))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Org.Visiontech.Provider.editResponse edit(Org.Visiontech.Provider.edit request);
        
        // CODEGEN: Il parametro 'return' richiede informazioni sullo schema aggiuntive che non possono essere acquisite utilizzando la modalità parametro. L'attributo specifico è 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(jsonbPolimorphic))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Org.Visiontech.Provider.findResponse find(Org.Visiontech.Provider.find request);
        
        // CODEGEN: Il parametro 'return' richiede informazioni sullo schema aggiuntive che non possono essere acquisite utilizzando la modalità parametro. L'attributo specifico è 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(jsonbPolimorphic))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Org.Visiontech.Provider.createResponse create(Org.Visiontech.Provider.create request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class providerDTO : descriptableDTO
    {
        
        private bool customField;
        
        private bool customFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool custom
        {
            get
            {
                return this.customField;
            }
            set
            {
                this.customField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool customSpecified
        {
            get
            {
                return this.customFieldSpecified;
            }
            set
            {
                this.customFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(providerDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public abstract partial class descriptableDTO : codifiableDTO
    {
        
        private string descriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(descriptableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(providerDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public abstract partial class codifiableDTO : validableDTO
    {
        
        private string codeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(codifiableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(descriptableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(providerDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public abstract partial class validableDTO : deletableDTO
    {
        
        private bool validField;
        
        private bool validFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool valid
        {
            get
            {
                return this.validField;
            }
            set
            {
                this.validField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool validSpecified
        {
            get
            {
                return this.validFieldSpecified;
            }
            set
            {
                this.validFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(validableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(codifiableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(descriptableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(providerDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public abstract partial class deletableDTO : modifiableDTO
    {
        
        private bool deletedField;
        
        private bool deletedFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool deleted
        {
            get
            {
                return this.deletedField;
            }
            set
            {
                this.deletedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deletedSpecified
        {
            get
            {
                return this.deletedFieldSpecified;
            }
            set
            {
                this.deletedFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(deletableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(validableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(codifiableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(descriptableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(providerDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public abstract partial class modifiableDTO : createdDTO
    {
        
        private System.DateTime modifiedField;
        
        private bool modifiedFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public System.DateTime modified
        {
            get
            {
                return this.modifiedField;
            }
            set
            {
                this.modifiedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool modifiedSpecified
        {
            get
            {
                return this.modifiedFieldSpecified;
            }
            set
            {
                this.modifiedFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(modifiableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(deletableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(validableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(codifiableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(descriptableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(providerDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public abstract partial class createdDTO : identifiableDTO
    {
        
        private System.DateTime creationField;
        
        private bool creationFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public System.DateTime creation
        {
            get
            {
                return this.creationField;
            }
            set
            {
                this.creationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool creationSpecified
        {
            get
            {
                return this.creationFieldSpecified;
            }
            set
            {
                this.creationFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(createdDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(modifiableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(deletableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(validableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(codifiableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(descriptableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(providerDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public abstract partial class identifiableDTO : jsonbPolimorphic
    {
        
        private string idField;
        
        private long versionField;
        
        private bool versionFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public long version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool versionSpecified
        {
            get
            {
                return this.versionFieldSpecified;
            }
            set
            {
                this.versionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(findCriteriaDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(relationalCriteriaDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(rangeCriteriaDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(simpleCriteriaDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(findResultDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(identifiableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(createdDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(modifiableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(deletableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(validableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(codifiableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(descriptableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(providerDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public abstract partial class jsonbPolimorphic
    {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(relationalCriteriaDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(rangeCriteriaDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(simpleCriteriaDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public abstract partial class findCriteriaDTO : jsonbPolimorphic
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class relationalCriteriaDTO : findCriteriaDTO
    {
        
        private findCriteriaDTO relatedField;
        
        private relationalCriteriaDTOEntry[] relationsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public findCriteriaDTO related
        {
            get
            {
                return this.relatedField;
            }
            set
            {
                this.relatedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("entry", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public relationalCriteriaDTOEntry[] relations
        {
            get
            {
                return this.relationsField;
            }
            set
            {
                this.relationsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class relationalCriteriaDTOEntry
    {
        
        private string keyField;
        
        private findCriteriaDTO valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public findCriteriaDTO value
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class rangeCriteriaDTO : findCriteriaDTO
    {
        
        private identifiableDTO fromField;
        
        private identifiableDTO toField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public identifiableDTO from
        {
            get
            {
                return this.fromField;
            }
            set
            {
                this.fromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public identifiableDTO to
        {
            get
            {
                return this.toField;
            }
            set
            {
                this.toField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class simpleCriteriaDTO : findCriteriaDTO
    {
        
        private identifiableDTO criteriaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public identifiableDTO criteria
        {
            get
            {
                return this.criteriaField;
            }
            set
            {
                this.criteriaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class findResultDTO : jsonbPolimorphic
    {
        
        private long countField;
        
        private bool countFieldSpecified;
        
        private identifiableDTO[] resultsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool countSpecified
        {
            get
            {
                return this.countFieldSpecified;
            }
            set
            {
                this.countFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("results", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public identifiableDTO[] results
        {
            get
            {
                return this.resultsField;
            }
            set
            {
                this.resultsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="delete", WrapperNamespace="http://soap.service.optoplus.visiontech.org/", IsWrapped=true)]
    public partial class delete
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.service.optoplus.visiontech.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("arg0", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Org.Visiontech.Provider.providerDTO[] arg0;
        
        public delete()
        {
        }
        
        public delete(Org.Visiontech.Provider.providerDTO[] arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="deleteResponse", WrapperNamespace="http://soap.service.optoplus.visiontech.org/", IsWrapped=true)]
    public partial class deleteResponse
    {
        
        public deleteResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="edit", WrapperNamespace="http://soap.service.optoplus.visiontech.org/", IsWrapped=true)]
    public partial class edit
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.service.optoplus.visiontech.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("arg0", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Org.Visiontech.Provider.providerDTO[] arg0;
        
        public edit()
        {
        }
        
        public edit(Org.Visiontech.Provider.providerDTO[] arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="editResponse", WrapperNamespace="http://soap.service.optoplus.visiontech.org/", IsWrapped=true)]
    public partial class editResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.service.optoplus.visiontech.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Org.Visiontech.Provider.providerDTO[] @return;
        
        public editResponse()
        {
        }
        
        public editResponse(Org.Visiontech.Provider.providerDTO[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="find", WrapperNamespace="http://soap.service.optoplus.visiontech.org/", IsWrapped=true)]
    public partial class find
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.service.optoplus.visiontech.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("arg0", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Org.Visiontech.Provider.findCriteriaDTO[] arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.service.optoplus.visiontech.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.service.optoplus.visiontech.org/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg2;
        
        public find()
        {
        }
        
        public find(Org.Visiontech.Provider.findCriteriaDTO[] arg0, int arg1, int arg2)
        {
            this.arg0 = arg0;
            this.arg1 = arg1;
            this.arg2 = arg2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findResponse", WrapperNamespace="http://soap.service.optoplus.visiontech.org/", IsWrapped=true)]
    public partial class findResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.service.optoplus.visiontech.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Org.Visiontech.Provider.findResultDTO @return;
        
        public findResponse()
        {
        }
        
        public findResponse(Org.Visiontech.Provider.findResultDTO @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create", WrapperNamespace="http://soap.service.optoplus.visiontech.org/", IsWrapped=true)]
    public partial class create
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.service.optoplus.visiontech.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("arg0", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Org.Visiontech.Provider.providerDTO[] arg0;
        
        public create()
        {
        }
        
        public create(Org.Visiontech.Provider.providerDTO[] arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createResponse", WrapperNamespace="http://soap.service.optoplus.visiontech.org/", IsWrapped=true)]
    public partial class createResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.service.optoplus.visiontech.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Org.Visiontech.Provider.providerDTO[] @return;
        
        public createResponse()
        {
        }
        
        public createResponse(Org.Visiontech.Provider.providerDTO[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProviderSoapChannel : Org.Visiontech.Provider.ProviderSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProviderSoapClient : System.ServiceModel.ClientBase<Org.Visiontech.Provider.ProviderSoap>, Org.Visiontech.Provider.ProviderSoap
    {
        
        public ProviderSoapClient()
        {
        }
        
        public ProviderSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ProviderSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ProviderSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ProviderSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Org.Visiontech.Provider.deleteResponse Org.Visiontech.Provider.ProviderSoap.delete(Org.Visiontech.Provider.delete request)
        {
            return base.Channel.delete(request);
        }
        
        public void delete(Org.Visiontech.Provider.providerDTO[] arg0)
        {
            Org.Visiontech.Provider.delete inValue = new Org.Visiontech.Provider.delete();
            inValue.arg0 = arg0;
            Org.Visiontech.Provider.deleteResponse retVal = ((Org.Visiontech.Provider.ProviderSoap)(this)).delete(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Org.Visiontech.Provider.editResponse Org.Visiontech.Provider.ProviderSoap.edit(Org.Visiontech.Provider.edit request)
        {
            return base.Channel.edit(request);
        }
        
        public Org.Visiontech.Provider.providerDTO[] edit(Org.Visiontech.Provider.providerDTO[] arg0)
        {
            Org.Visiontech.Provider.edit inValue = new Org.Visiontech.Provider.edit();
            inValue.arg0 = arg0;
            Org.Visiontech.Provider.editResponse retVal = ((Org.Visiontech.Provider.ProviderSoap)(this)).edit(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Org.Visiontech.Provider.findResponse Org.Visiontech.Provider.ProviderSoap.find(Org.Visiontech.Provider.find request)
        {
            return base.Channel.find(request);
        }
        
        public Org.Visiontech.Provider.findResultDTO find(Org.Visiontech.Provider.findCriteriaDTO[] arg0, int arg1, int arg2)
        {
            Org.Visiontech.Provider.find inValue = new Org.Visiontech.Provider.find();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            inValue.arg2 = arg2;
            Org.Visiontech.Provider.findResponse retVal = ((Org.Visiontech.Provider.ProviderSoap)(this)).find(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Org.Visiontech.Provider.createResponse Org.Visiontech.Provider.ProviderSoap.create(Org.Visiontech.Provider.create request)
        {
            return base.Channel.create(request);
        }
        
        public Org.Visiontech.Provider.providerDTO[] create(Org.Visiontech.Provider.providerDTO[] arg0)
        {
            Org.Visiontech.Provider.create inValue = new Org.Visiontech.Provider.create();
            inValue.arg0 = arg0;
            Org.Visiontech.Provider.createResponse retVal = ((Org.Visiontech.Provider.ProviderSoap)(this)).create(inValue);
            return retVal.@return;
        }
    }
}
