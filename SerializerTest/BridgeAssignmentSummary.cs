using eTakeoff.Domain;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;

namespace eTakeoff.Bridge.Core.Model
{
    public class BridgeAssignmentSummary : IRStreamable
    {
        #region Fields

        private Collection<BridgeAssignmentResourceSummary> _resourceCollection;
        private Collection<BridgeAssignmentTakeoffObjectSummary> _takeoffObjectCollection;
        private Collection<BridgeAssignmentPassSummary> _assignmentPassCollection;
        private Collection<BridgeAssignmentEstItemSummary> _itemDetailCollection;

        #endregion

        #region Properties

        public string AssignmentId { get; set; }
        public ResourceType ResourceType
        {
            get
            {
                if (ResourceCollection != null && ResourceCollection.Any())
                {
                    return ResourceCollection.First().ResourceType;
                }

                return ResourceType.Item;
            }
        }

        public Collection<BridgeAssignmentResourceSummary> ResourceCollection
        {
            get
            {
                if (_resourceCollection == null)
                    _resourceCollection = new Collection<BridgeAssignmentResourceSummary>();
                return _resourceCollection;
            }
            set { _resourceCollection = value; }
        }

        public Collection<BridgeAssignmentTakeoffObjectSummary> TakeoffObjectCollection
        {
            get
            {
                if (_takeoffObjectCollection == null)
                    _takeoffObjectCollection = new Collection<BridgeAssignmentTakeoffObjectSummary>();
                return _takeoffObjectCollection;
            }
            set { _takeoffObjectCollection = value; }
        }

        public Collection<BridgeAssignmentPassSummary> AssignmentPassCollection
        {
            get
            {
                if (_assignmentPassCollection == null)
                    _assignmentPassCollection = new Collection<BridgeAssignmentPassSummary>();
                return _assignmentPassCollection;
            }
            set { _assignmentPassCollection = value; }
        }

        public Collection<BridgeAssignmentEstItemSummary> ItemDetailCollection
        {
            get
            {
                if (_itemDetailCollection == null)
                    _itemDetailCollection = new Collection<BridgeAssignmentEstItemSummary>();
                return _itemDetailCollection;
            }
            set { _itemDetailCollection = value; }
        }

        public IEnumerable<BridgeAssignmentTakeoffObjectSummary> PrimaryTkoCollection
        {
            get
            {
                return
                    AssignmentPassCollection.Where(pass => pass.PrimaryTakeoffObjectCollection != null)
                    .SelectMany(pass => pass.PrimaryTakeoffObjectCollection);
            }
        }

        #endregion

        public void StreamIn(RStrmIn reader)
        {
            while (reader.MoveNext())
            {
                int propertyId = reader.GetPropertyId(ModelSchema.BridgeAssignmentKeywordArray);
                if (propertyId == -1)
                    propertyId = reader.GetPropertyId(ModelSchema.BridgeAssignmentKeywordArrayOld);

                switch (propertyId)
                {
                    case (int)BridgeAssignmentProperty.Tko:
                        {
                            var obj = new BridgeAssignmentTakeoffObjectSummary();
                            obj.StreamIn(reader);
                            TakeoffObjectCollection.Add(obj);
                            break;
                        }

                    case (int)BridgeAssignmentProperty.Res:
                        {
                            var obj = new BridgeAssignmentResourceSummary();
                            obj.StreamIn(reader);
                            ResourceCollection.Add(obj);
                            break;
                        }
                    case (int)BridgeAssignmentProperty.Pass:
                        {
                            var obj = new BridgeAssignmentPassSummary();
                            obj.StreamIn(reader);
                            AssignmentPassCollection.Add(obj);
                            break;
                        }
                    case (int)BridgeAssignmentProperty.Item:
                        {
                            var obj = new BridgeAssignmentEstItemSummary();
                            obj.StreamIn(reader);
                            ItemDetailCollection.Add(obj);
                            break;
                        }
                    case (int)BridgeAssignmentProperty.AsnId:
                        AssignmentId = reader.ReadString();
                        break;
                }
            }

            foreach (var obj in AssignmentPassCollection)
            {
                if (obj.PrimaryTakeoffNumber >= 0)
                {
                    var takeoffItem =
                        TakeoffObjectCollection.FirstOrDefault(tko => tko.TkoRefId == obj.PrimaryTakeoffNumber);
                    if (takeoffItem != null)
                    {
                        takeoffItem.TkoRefId = obj.PrimaryTakeoffNumber;
                        obj.PrimaryTakeoffObjectCollection.Add(takeoffItem);
                    }
                }
            }
        }

        public void StreamOut(RStrmOut writer)
        {

            foreach (var obj in AssignmentPassCollection)
            {
                if (obj.PrimaryTakeoffObjectCollection == null || obj.PrimaryTakeoffObjectCollection.Count() == 0)
                    obj.PrimaryTakeoffNumber = -1;
                else
                {
                    if (TakeoffObjectCollection != null)
                    {
                        var primaryTko =
                            obj.PrimaryTakeoffObjectCollection.FirstOrDefault();
                        obj.PrimaryTakeoffNumber = primaryTko.TkoRefId;
                    }
                }
            }

            writer.ObjectBegin("");
            foreach (var property in ModelSchema.BridgeAssignmentKeywordArray.RKwdCollection)
            {
                string propertyName = property.Name;
                switch (property.Id)
                {
                    case (int)BridgeAssignmentProperty.Tko:
                        if (TakeoffObjectCollection != null)
                            foreach (var item in TakeoffObjectCollection)
                            {
                                writer.ObjectBegin(propertyName);
                                item.StreamOut(writer);
                                writer.ObjectEnd();
                            }
                        break;
                    case (int)BridgeAssignmentProperty.Res:
                        foreach (var item in ResourceCollection)
                        {
                            writer.ObjectBegin(propertyName);
                            item.StreamOut(writer);
                            writer.ObjectEnd();
                        }
                        break;
                    case (int)BridgeAssignmentProperty.Pass:
                        foreach (var item in AssignmentPassCollection)
                        {
                            writer.ObjectBegin(propertyName);
                            item.StreamOut(writer);
                            writer.ObjectEnd();
                        }
                        break;
                    case (int)BridgeAssignmentProperty.Item:
                        foreach (var item in ItemDetailCollection)
                        {
                            writer.ObjectBegin(propertyName);
                            item.StreamOut(writer);
                            writer.ObjectEnd();
                        }
                        break;
                    case (int)BridgeAssignmentProperty.AsnId:
                        writer.WriteString(propertyName, AssignmentId);
                        break;
                }
            }
            writer.ObjectEnd();
        }
    }

    public class BridgeAssignmentEstItemSummary : IRStreamable
    {
        #region Fields

        private Collection<VariableAssignmentSummary> _variableAssignmentList;

        #endregion

        #region Properties

        public string EstItemId { get; set; }
        public double QuantityGenerated { get; set; }

        public Collection<VariableAssignmentSummary> VariableAssignmentList
        {
            get
            {
                if (_variableAssignmentList == null)
                    _variableAssignmentList = new Collection<VariableAssignmentSummary>();
                return _variableAssignmentList;
            }
            set { _variableAssignmentList = value; }
        }

        #endregion

        public void StreamIn(RStrmIn reader)
        {
            while (reader.MoveNext())
            {
                int propertyId = reader.GetPropertyId(ModelSchema.BridgeAssignmentEstItemKeywordArray);
                if (propertyId == -1)
                    propertyId = reader.GetPropertyId(ModelSchema.BridgeAssignmentEstItemKeywordArrayOld);

                switch (propertyId)
                {
                    case (int)BridgeAssignEstItemProperty.Id:
                        EstItemId = reader.ReadString();
                        break;
                    case (int)BridgeAssignEstItemProperty.Qty:
                        QuantityGenerated = reader.ReadDouble();
                        break;
                    case (int)BridgeAssignEstItemProperty.Asn:
                        var obj = new VariableAssignmentSummary();
                        obj.StreamIn(reader);
                        VariableAssignmentList.Add(obj);
                        break;
                }
            }
        }

        public void StreamOut(RStrmOut writer)
        {
            foreach (var property in ModelSchema.BridgeAssignmentEstItemKeywordArray.RKwdCollection)
            {
                string propertyName = property.Name;
                switch (property.Id)
                {
                    case (int)BridgeAssignEstItemProperty.Id:
                        writer.WriteString(propertyName, EstItemId);
                        break;
                    case (int)BridgeAssignEstItemProperty.Qty:
                        writer.WriteDouble(propertyName, QuantityGenerated, 4);
                        break;
                    case (int)BridgeAssignEstItemProperty.Asn:
                        foreach (var item in VariableAssignmentList)
                        {
                            writer.ObjectBegin(propertyName);
                            item.StreamOut(writer);
                            writer.ObjectEnd();
                        }
                        break;
                }
            }
        }
    }

    public class BridgeAssignmentPassSummary : IRStreamable
    {
        #region Fields

        private Collection<VariableAssignmentSummary> _variableAssignmentList;
        private Collection<BridgeAssignmentTakeoffObjectSummary> _primaryTakeoffObjectCollection;

        #endregion

        #region Properties

        public int PrimaryTakeoffNumber { get; set; }

        public Collection<VariableAssignmentSummary> VariableAssignmentList
        {
            get
            {
                if (_variableAssignmentList == null)
                    _variableAssignmentList = new Collection<VariableAssignmentSummary>();
                return _variableAssignmentList;
            }
            set { _variableAssignmentList = value; }
        }

        public Collection<BridgeAssignmentTakeoffObjectSummary> PrimaryTakeoffObjectCollection
        {
            get
            {
                if (_primaryTakeoffObjectCollection == null)
                    _primaryTakeoffObjectCollection = new Collection<BridgeAssignmentTakeoffObjectSummary>();
                return _primaryTakeoffObjectCollection;
            }
            set { _primaryTakeoffObjectCollection = value; }
        }

        #endregion

        public void StreamIn(RStrmIn reader)
        {
            while (reader.MoveNext())
            {
                int propertyId = reader.GetPropertyId(ModelSchema.BridgeAssignmentPassKeywordArray);
                if (propertyId == -1)
                    propertyId = reader.GetPropertyId(ModelSchema.BridgeAssignmentPassKeywordArrayOld);

                switch (propertyId)
                {
                    case (int)BridgeAssignPassProperty.PTko:
                        PrimaryTakeoffNumber = reader.ReadInteger();
                        break;
                    case (int)BridgeAssignPassProperty.Asn:
                        var obj = new VariableAssignmentSummary();
                        obj.StreamIn(reader);
                        VariableAssignmentList.Add(obj);
                        break;
                }
            }
        }

        public void StreamOut(RStrmOut writer)
        {
            foreach (var property in ModelSchema.BridgeAssignmentPassKeywordArray.RKwdCollection)
            {
                string propertyName = property.Name;
                switch (property.Id)
                {
                    case (int)BridgeAssignPassProperty.PTko:
                        writer.WriteInteger(propertyName, PrimaryTakeoffNumber);
                        break;
                    case (int)BridgeAssignPassProperty.Asn:
                        foreach (var item in VariableAssignmentList)
                        {
                            writer.ObjectBegin(propertyName);
                            item.StreamOut(writer);
                            writer.ObjectEnd();
                        }
                        break;
                }
            }
        }
    }

    public class BridgeAssignmentResourceSummary : IRStreamable
    {
        #region Properties

        public string ResourceId { get; set; }
        public ResourceType ResourceType { get; set; }
        public string Description { get; set; }

        #endregion

        public void StreamIn(RStrmIn reader)
        {
            while (reader.MoveNext())
            {
                int propertyId = reader.GetPropertyId(ModelSchema.BridgeAssignmentResourceKeywordArray);
                if (propertyId == -1)
                    propertyId = reader.GetPropertyId(ModelSchema.BridgeAssignmentResourceKeywordArrayOld);

                switch (propertyId)
                {
                    case (int)BridgeAssignResourceProperty.Id:
                        {
                            ResourceId = reader.ReadString();
                            break;
                        }
                    case (int)BridgeAssignResourceProperty.Typ:
                        {
                            reader.ReadString();
                            //var input = reader.ReadString()[0;
                            //if (input == 'I')
                            //    ResourceType = ResourceType.Item;
                            //if (input == 'A')
                            //    ResourceType = ResourceType.Assembly;
                            //if (input == 'S')
                            //    ResourceType = ResourceType.ETakeoffBridgeAssembly;

                            break;
                        }
                    case (int)BridgeAssignResourceProperty.Desc:
                        {
                            Description = reader.ReadString();
                            break;
                        }
                }
            }
        }

        public void StreamOut(RStrmOut writer)
        {
            foreach (var property in ModelSchema.BridgeAssignmentResourceKeywordArray.RKwdCollection)
            {
                string propertyName = property.Name;
                switch (property.Id)
                {
                    case (int)BridgeAssignResourceProperty.Id:
                        {
                            writer.WriteString(propertyName, ResourceId);
                            break;
                        }
                    case (int)BridgeAssignResourceProperty.Typ:
                        {
                            var value = 'I';
                            if (ResourceType == ResourceType.Item)
                                value = 'I';
                            if (ResourceType == ResourceType.Assembly)
                                value = 'A';
                            value = 'S';
                            writer.WriteString(propertyName, value.ToString(CultureInfo.InvariantCulture));
                            break;
                        }
                    case (int)BridgeAssignResourceProperty.Desc:
                        {
                            writer.WriteString(propertyName, Description);
                            break;
                        }
                }
            }
        }
    }

    public class BridgeAssignmentTakeoffObjectSummary : IRStreamable
    {
        #region Properties

        public string TkoSystemId { get; set; }
        public string TkoProjectId { get; set; }
        public string TkoTypeId { get; set; }
        public int TkoRefId { get; set; }
        public string TkoId { get; set; }
        public string Description { get; set; }

        #endregion

        public void StreamIn(RStrmIn reader)
        {
            while (reader.MoveNext())
            {
                int propertyId = reader.GetPropertyId(ModelSchema.BridgeAssignmentTakeoffObjectKeywordArray);
                if (propertyId == -1)
                    propertyId = reader.GetPropertyId(ModelSchema.BridgeAssignmentTakeoffObjectKeywordArrayOld);

                switch (propertyId)
                {
                    case (int)BridgeAssignTakeoffProperty.SId:
                        TkoSystemId = reader.ReadString();
                        break;
                    case (int)BridgeAssignTakeoffProperty.Proj:
                        TkoProjectId = reader.ReadString();
                        break;
                    case (int)BridgeAssignTakeoffProperty.Id:
                        TkoId = reader.ReadString();
                        break;
                    case (int)BridgeAssignTakeoffProperty.Typ:
                        TkoTypeId = reader.ReadString();
                        break;
                    case (int)BridgeAssignTakeoffProperty.RfId:
                        TkoRefId = reader.ReadInteger();
                        break;
                    case (int)BridgeAssignTakeoffProperty.Desc:
                        Description = reader.ReadString();
                        break;
                }
            }
        }

        public void StreamOut(RStrmOut writer)
        {
            foreach (var property in ModelSchema.BridgeAssignmentTakeoffObjectKeywordArray.RKwdCollection)
            {
                string propertyName = property.Name;
                switch (property.Id)
                {
                    case (int)BridgeAssignTakeoffProperty.SId:
                        writer.WriteString(propertyName, TkoSystemId);
                        break;
                    case (int)BridgeAssignTakeoffProperty.Proj:
                        writer.WriteString(propertyName, TkoProjectId);
                        break;
                    case (int)BridgeAssignTakeoffProperty.Id:
                        writer.WriteString(propertyName, TkoId);
                        break;
                    case (int)BridgeAssignTakeoffProperty.Typ:
                        writer.WriteString(propertyName, TkoTypeId);
                        break;
                    case (int)BridgeAssignTakeoffProperty.RfId:
                        writer.WriteInteger(propertyName, TkoRefId);
                        break;
                    case (int)BridgeAssignTakeoffProperty.Desc:
                        writer.WriteString(propertyName, Description);
                        break;
                }
            }
        }
    }

    public class VariableAssignmentSummary : IRStreamable
    {
        private string _fromOverrideValue;

        #region Properties
        public bool MissingTkoVariable { get; set; }
        public int FromTakeoffNumber { get; set; }
        public string FromVariableName { get; set; }
        public string ToVariableName { get; set; }
        public string VariableValue { get; set; }
        public string FromOverflowValue
        {
            get
            {
                if (string.IsNullOrEmpty(_fromOverrideValue))
                    _fromOverrideValue = VariableValue;
                return _fromOverrideValue;
            }
            set
            {
                _fromOverrideValue = value;
            }
        }

        #endregion

        public void StreamIn(RStrmIn reader)
        {
            while (reader.MoveNext())
            {
                int propertyId = reader.GetPropertyId(ModelSchema.VariableAssignmentKeywordArray);
                if (propertyId == -1)
                    propertyId = reader.GetPropertyId(ModelSchema.VariableAssignmentKeywordArrayOld);

                switch (propertyId)
                {
                    case (int)BridgeAssignVariableAssignProperty.Tko:
                        FromTakeoffNumber = reader.ReadInteger();
                        break;
                    case (int)BridgeAssignVariableAssignProperty.FVar:
                        FromVariableName = reader.ReadString();
                        break;
                    case (int)BridgeAssignVariableAssignProperty.TVar:
                        ToVariableName = reader.ReadString();
                        break;
                    case (int)BridgeAssignVariableAssignProperty.Val:
                        VariableValue = reader.ReadString();
                        break;
                    case (int)BridgeAssignVariableAssignProperty.FOVal:
                        FromOverflowValue = reader.ReadString();
                        break;
                    case (int)BridgeAssignVariableAssignProperty.HasFV:
                        reader.ReadBoolean();
                        break;
                    case (int)BridgeAssignVariableAssignProperty.MTko:
                        MissingTkoVariable = reader.ReadBoolean();
                        break;
                }
            }
        }

        public void StreamOut(RStrmOut writer)
        {
            if (string.Equals(VariableValue, _fromOverrideValue))
                _fromOverrideValue = string.Empty;

            foreach (var property in ModelSchema.VariableAssignmentKeywordArray.RKwdCollection)
            {
                string propertyName = property.Name;
                switch (property.Id)
                {
                    case (int)BridgeAssignVariableAssignProperty.Tko:
                        writer.WriteInteger(propertyName, FromTakeoffNumber);
                        break;
                    case (int)BridgeAssignVariableAssignProperty.FVar:
                        writer.WriteString(propertyName, FromVariableName);
                        break;
                    case (int)BridgeAssignVariableAssignProperty.TVar:
                        writer.WriteString(propertyName, ToVariableName);
                        break;
                    case (int)BridgeAssignVariableAssignProperty.Val:
                        writer.WriteString(propertyName, VariableValue);
                        break;
                    case (int)BridgeAssignVariableAssignProperty.FOVal:
                        writer.WriteString(propertyName, _fromOverrideValue);
                        break;
                    case (int)BridgeAssignVariableAssignProperty.MTko:
                        writer.WriteBoolean(propertyName, MissingTkoVariable);
                        break;
                }
            }
        }
    }
}
