﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Org.Visiontech.Contact
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://soap.service.optoplus.visiontech.org/", ConfigurationName="Org.Visiontech.Contact.ContactSoap")]
    public interface ContactSoap
    {
        
        // CODEGEN: Il parametro 'arg0' richiede informazioni sullo schema aggiuntive che non possono essere acquisite utilizzando la modalità parametro. L'attributo specifico è 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(jsonbPolimorphic))]
        Org.Visiontech.Contact.deleteResponse delete(Org.Visiontech.Contact.delete request);
        
        // CODEGEN: Il parametro 'return' richiede informazioni sullo schema aggiuntive che non possono essere acquisite utilizzando la modalità parametro. L'attributo specifico è 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(jsonbPolimorphic))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Org.Visiontech.Contact.editResponse edit(Org.Visiontech.Contact.edit request);
        
        // CODEGEN: Il parametro 'return' richiede informazioni sullo schema aggiuntive che non possono essere acquisite utilizzando la modalità parametro. L'attributo specifico è 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(jsonbPolimorphic))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Org.Visiontech.Contact.findResponse find(Org.Visiontech.Contact.find request);
        
        // CODEGEN: Il parametro 'return' richiede informazioni sullo schema aggiuntive che non possono essere acquisite utilizzando la modalità parametro. L'attributo specifico è 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(jsonbPolimorphic))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Org.Visiontech.Contact.createResponse create(Org.Visiontech.Contact.create request);
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(personContactDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class contactDTO : codifiableDTO
    {
        
        private contactType typeField;
        
        private bool typeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public contactType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public enum contactType
    {
        
        /// <remarks/>
        PHONE,
        
        /// <remarks/>
        CELLPHONE,
        
        /// <remarks/>
        EMAIL,
        
        /// <remarks/>
        UNKNOWN,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(contactDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(personContactDTO))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(personDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(codifiableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(contactDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(personContactDTO))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(personDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(codifiableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(contactDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(personContactDTO))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(personDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(codifiableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(contactDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(personContactDTO))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(personDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(codifiableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(contactDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(personContactDTO))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(personDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(codifiableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(contactDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(personContactDTO))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(findResultDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(findCriteriaDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(relationalCriteriaDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(rangeCriteriaDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(simpleCriteriaDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(identifiableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(createdDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(modifiableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(deletableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(validableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(personDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(codifiableDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(contactDTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(personContactDTO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public abstract partial class jsonbPolimorphic
    {
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
    public partial class personDTO : validableDTO
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.service.optoplus.visiontech.org/")]
    public partial class personContactDTO : contactDTO
    {
        
        private personDTO personField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public personDTO person
        {
            get
            {
                return this.personField;
            }
            set
            {
                this.personField = value;
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
        public Org.Visiontech.Contact.contactDTO[] arg0;
        
        public delete()
        {
        }
        
        public delete(Org.Visiontech.Contact.contactDTO[] arg0)
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
        public Org.Visiontech.Contact.contactDTO[] arg0;
        
        public edit()
        {
        }
        
        public edit(Org.Visiontech.Contact.contactDTO[] arg0)
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
        public Org.Visiontech.Contact.contactDTO[] @return;
        
        public editResponse()
        {
        }
        
        public editResponse(Org.Visiontech.Contact.contactDTO[] @return)
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
        public Org.Visiontech.Contact.findCriteriaDTO[] arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.service.optoplus.visiontech.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.service.optoplus.visiontech.org/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg2;
        
        public find()
        {
        }
        
        public find(Org.Visiontech.Contact.findCriteriaDTO[] arg0, int arg1, int arg2)
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
        public Org.Visiontech.Contact.findResultDTO @return;
        
        public findResponse()
        {
        }
        
        public findResponse(Org.Visiontech.Contact.findResultDTO @return)
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
        public Org.Visiontech.Contact.contactDTO[] arg0;
        
        public create()
        {
        }
        
        public create(Org.Visiontech.Contact.contactDTO[] arg0)
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
        public Org.Visiontech.Contact.contactDTO[] @return;
        
        public createResponse()
        {
        }
        
        public createResponse(Org.Visiontech.Contact.contactDTO[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ContactSoapChannel : Org.Visiontech.Contact.ContactSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ContactSoapClient : System.ServiceModel.ClientBase<Org.Visiontech.Contact.ContactSoap>, Org.Visiontech.Contact.ContactSoap
    {
        
        public ContactSoapClient()
        {
        }
        
        public ContactSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ContactSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ContactSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ContactSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Org.Visiontech.Contact.deleteResponse Org.Visiontech.Contact.ContactSoap.delete(Org.Visiontech.Contact.delete request)
        {
            return base.Channel.delete(request);
        }
        
        public void delete(Org.Visiontech.Contact.contactDTO[] arg0)
        {
            Org.Visiontech.Contact.delete inValue = new Org.Visiontech.Contact.delete();
            inValue.arg0 = arg0;
            Org.Visiontech.Contact.deleteResponse retVal = ((Org.Visiontech.Contact.ContactSoap)(this)).delete(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Org.Visiontech.Contact.editResponse Org.Visiontech.Contact.ContactSoap.edit(Org.Visiontech.Contact.edit request)
        {
            return base.Channel.edit(request);
        }
        
        public Org.Visiontech.Contact.contactDTO[] edit(Org.Visiontech.Contact.contactDTO[] arg0)
        {
            Org.Visiontech.Contact.edit inValue = new Org.Visiontech.Contact.edit();
            inValue.arg0 = arg0;
            Org.Visiontech.Contact.editResponse retVal = ((Org.Visiontech.Contact.ContactSoap)(this)).edit(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Org.Visiontech.Contact.findResponse Org.Visiontech.Contact.ContactSoap.find(Org.Visiontech.Contact.find request)
        {
            return base.Channel.find(request);
        }
        
        public Org.Visiontech.Contact.findResultDTO find(Org.Visiontech.Contact.findCriteriaDTO[] arg0, int arg1, int arg2)
        {
            Org.Visiontech.Contact.find inValue = new Org.Visiontech.Contact.find();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            inValue.arg2 = arg2;
            Org.Visiontech.Contact.findResponse retVal = ((Org.Visiontech.Contact.ContactSoap)(this)).find(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Org.Visiontech.Contact.createResponse Org.Visiontech.Contact.ContactSoap.create(Org.Visiontech.Contact.create request)
        {
            return base.Channel.create(request);
        }
        
        public Org.Visiontech.Contact.contactDTO[] create(Org.Visiontech.Contact.contactDTO[] arg0)
        {
            Org.Visiontech.Contact.create inValue = new Org.Visiontech.Contact.create();
            inValue.arg0 = arg0;
            Org.Visiontech.Contact.createResponse retVal = ((Org.Visiontech.Contact.ContactSoap)(this)).create(inValue);
            return retVal.@return;
        }
    }
}
