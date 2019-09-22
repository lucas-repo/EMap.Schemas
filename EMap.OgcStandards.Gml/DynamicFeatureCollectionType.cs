﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("DynamicFeatureCollection", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class DynamicFeatureCollectionType : DynamicFeatureType {
        
        private DynamicFeatureMemberType dynamicMembersField;
        
        /// <remarks/>
        public DynamicFeatureMemberType dynamicMembers {
            get {
                return this.dynamicMembersField;
            }
            set {
                this.dynamicMembersField = value;
            }
        }
    }
}