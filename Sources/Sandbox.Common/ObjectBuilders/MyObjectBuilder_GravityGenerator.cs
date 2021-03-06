﻿using System.Collections.Generic;
using ProtoBuf;
using VRageMath;
using System.Xml.Serialization;
using System.ComponentModel;
using Sandbox.Common.ObjectBuilders.VRageData;


namespace Sandbox.Common.ObjectBuilders
{
    [ProtoContract]
    [MyObjectBuilderDefinition]
    public class MyObjectBuilder_GravityGenerator : MyObjectBuilder_FunctionalBlock
    {
        //[ProtoMember(1), DefaultValue(true)]
        //public bool Enabled = true;

        [ProtoMember(2)]
        public SerializableVector3 FieldSize = new SerializableVector3(150f, 150f, 150f);

        [ProtoMember(3), DefaultValue(9.81f)]
        public float GravityAcceleration = 9.81f;


    }
}
