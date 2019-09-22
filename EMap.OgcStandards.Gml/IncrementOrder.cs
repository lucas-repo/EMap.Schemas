namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public enum IncrementOrder {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("+x+y")]
        xy,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("+y+x")]
        yx,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("+x-y")]
        xy1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("-x-y")]
        xy2,
    }
}
