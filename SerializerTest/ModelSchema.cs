using eTakeoff.Domain;
using System;

namespace eTakeoff.Bridge.Core.Model
{
    public class ModelSchema
    {
        public static RKwdMap AssignmentEstItemKeywordArray = new RKwdMap(new[]
            {
                new RKwd((int) AssignEstItemProperty.Id, AssignEstItemProperty.Id.ToString()),
                new RKwd((int) AssignEstItemProperty.Asgn, AssignEstItemProperty.Asgn.ToString()),
                 new RKwd((int) AssignEstItemProperty.ITb, AssignEstItemProperty.ITb.ToString())
            });

        public static RKwdMap AssignmentEstItemKeywordArrayOld = new RKwdMap(new[]
            {
                new RKwd((int) AssignEstItemProperty.Id, "EstItemId"),
                new RKwd((int) AssignEstItemProperty.Asgn, "VariableAssign")
            });

        public static RKwdMap AssignmentHistoryKeywordArray = new RKwdMap(new[]
            {
                new RKwd((int) AssignmentProperty.TSId, AssignmentProperty.TSId.ToString()),
                new RKwd((int) AssignmentProperty.ESId, AssignmentProperty.ESId.ToString()),
                new RKwd((int) AssignmentProperty.TTyp, AssignmentProperty.TTyp.ToString()),
                new RKwd((int) AssignmentProperty.RId, AssignmentProperty.RId.ToString()),
                new RKwd((int) AssignmentProperty.RTyp, AssignmentProperty.RTyp.ToString()),
                new RKwd((int) AssignmentProperty.RDes, AssignmentProperty.RDes.ToString()),
                new RKwd((int) AssignmentProperty.Asgn, AssignmentProperty.Asgn.ToString()),
                new RKwd((int) AssignmentProperty.Item, AssignmentProperty.Item.ToString()),
                new RKwd((int) AssignmentProperty.Type, AssignmentProperty.Type.ToString()),
                new RKwd((int) AssignmentProperty.ItmH, AssignmentProperty.ItmH.ToString()),
                new RKwd((int) AssignmentProperty.AhId, AssignmentProperty.AhId.ToString())
            });

        public static RKwdMap AssignmentHistoryKeywordArrayOld = new RKwdMap(new[]
            {
                new RKwd((int) AssignmentProperty.TSId, "TakeoffSystemId"),
                new RKwd((int) AssignmentProperty.ESId, "EstSystemId"),
                new RKwd((int) AssignmentProperty.TTyp, "TakeoffObjectType"),
                new RKwd((int) AssignmentProperty.RId, "EstResourceId"),
                new RKwd((int) AssignmentProperty.RTyp, "EstResourceType"),
                new RKwd((int) AssignmentProperty.RDes, "EstResourceDesc"),
                new RKwd((int) AssignmentProperty.Asgn, "VariableAssign"),
                new RKwd((int) AssignmentProperty.Item, "AssignEstItem"),
                new RKwd((int) AssignmentProperty.Type, "AssignmentHistoryType")
            });


        public static RKwdMap BridgeAssignmentKeywordArray = new RKwdMap(new[]
            {
                new RKwd((int) BridgeAssignmentProperty.Tko, BridgeAssignmentProperty.Tko.ToString()),
                new RKwd((int) BridgeAssignmentProperty.Res, BridgeAssignmentProperty.Res.ToString()),
                new RKwd((int) BridgeAssignmentProperty.Pass, BridgeAssignmentProperty.Pass.ToString()),
                new RKwd((int) BridgeAssignmentProperty.Item, BridgeAssignmentProperty.Item.ToString()),
                new RKwd((int) BridgeAssignmentProperty.AsnId, BridgeAssignmentProperty.AsnId.ToString()),
                new RKwd((int) BridgeAssignmentProperty.BId, BridgeAssignmentProperty.BId.ToString()),
                new RKwd((int) BridgeAssignmentProperty.LTko, BridgeAssignmentProperty.LTko.ToString()),
                new RKwd((int) BridgeAssignmentProperty.Id, BridgeAssignmentProperty.Id.ToString()),
                new RKwd((int) BridgeAssignmentProperty.ECxt, BridgeAssignmentProperty.ECxt.ToString()),
                new RKwd((int) BridgeAssignmentProperty.CDel, BridgeAssignmentProperty.CDel.ToString()),
                new RKwd((int) BridgeAssignmentProperty.AH, BridgeAssignmentProperty.AH.ToString())
            });

        public static RKwdMap BridgeAssignmentKeywordArrayOld = new RKwdMap(new[]
            {
                new RKwd((int) BridgeAssignmentProperty.Tko, "Tko"),
                new RKwd((int) BridgeAssignmentProperty.Res, "Resource"),
                new RKwd((int) BridgeAssignmentProperty.Pass, "AssignmentPass"),
                new RKwd((int) BridgeAssignmentProperty.Item, "ItemDetail"),
                new RKwd((int) BridgeAssignmentProperty.AsnId, "AssignmentId"),
                new RKwd((int) BridgeAssignmentProperty.BId, "BridgeId"),
                new RKwd((int) BridgeAssignmentProperty.LTko, "LastTkoObjIndex"),
                new RKwd((int) BridgeAssignmentProperty.Id, "Id"),
                new RKwd((int) BridgeAssignmentProperty.ECxt, "EstAssignmentContext")
            });

        public static RKwdMap BridgeAssignmentEstItemKeywordArray = new RKwdMap(new[]
            {
                new RKwd((int) BridgeAssignEstItemProperty.Id, BridgeAssignEstItemProperty.Id.ToString()),
                new RKwd((int) BridgeAssignEstItemProperty.Qty,
                         BridgeAssignEstItemProperty.Qty.ToString()),
                new RKwd((int) BridgeAssignEstItemProperty.Desc, BridgeAssignEstItemProperty.Desc.ToString()),
                new RKwd((int) BridgeAssignEstItemProperty.Asn, BridgeAssignEstItemProperty.Asn.ToString()),
                new RKwd((int) BridgeAssignEstItemProperty.Idx, BridgeAssignEstItemProperty.Idx.ToString())
            });

        public static RKwdMap BridgeAssignmentEstItemKeywordArrayOld = new RKwdMap(new[]
            {
                new RKwd((int) BridgeAssignEstItemProperty.Id, "EstItemId"),
                new RKwd((int) BridgeAssignEstItemProperty.Qty,
                         "QuantityGenerated"),
                new RKwd((int) BridgeAssignEstItemProperty.Desc, "Description"),
                new RKwd((int) BridgeAssignEstItemProperty.Asn, "AssignList"),
                new RKwd((int) BridgeAssignEstItemProperty.Idx, "Index")
            });


        public static RKwdMap BridgeAssignmentPassKeywordArray = new RKwdMap(new[]
            {
                new RKwd((int) BridgeAssignPassProperty.PTko, BridgeAssignPassProperty.PTko.ToString()),
                new RKwd((int) BridgeAssignPassProperty.STko, BridgeAssignPassProperty.STko.ToString()),
                new RKwd((int) BridgeAssignPassProperty.Asn, BridgeAssignPassProperty.Asn.ToString()),
                new RKwd((int) BridgeAssignPassProperty.Id, BridgeAssignPassProperty.Id.ToString())
            });

        public static RKwdMap BridgeAssignmentPassKeywordArrayOld = new RKwdMap(new[]
            {
                new RKwd((int) BridgeAssignPassProperty.PTko, "PTko"),
                new RKwd((int) BridgeAssignPassProperty.STko, "STko"),
                new RKwd((int) BridgeAssignPassProperty.Asn, "VariableAssign"),
                new RKwd((int) BridgeAssignPassProperty.Id, "PassId")
            });


        public static RKwdMap BridgeAssignmentResourceKeywordArray = new RKwdMap(new[]
            {
                new RKwd((int) BridgeAssignResourceProperty.Id, BridgeAssignResourceProperty.Id.ToString()),
                new RKwd((int) BridgeAssignResourceProperty.Typ,
                         BridgeAssignResourceProperty.Typ.ToString()),
                new RKwd((int) BridgeAssignResourceProperty.Desc, BridgeAssignResourceProperty.Desc.ToString())
            });


        public static RKwdMap BridgeAssignmentResourceKeywordArrayOld = new RKwdMap(new[]
            {
                new RKwd((int) BridgeAssignResourceProperty.Id, "ResourceId"),
                new RKwd((int) BridgeAssignResourceProperty.Typ,
                         "ResourceType"),
                new RKwd((int) BridgeAssignResourceProperty.Desc, "Description")
            });

        public static RKwdMap BridgeAssignmentTakeoffObjectKeywordArray = new RKwdMap(new[]
            {
                new RKwd((int) BridgeAssignTakeoffProperty.SId, BridgeAssignTakeoffProperty.SId.ToString()),
                new RKwd((int) BridgeAssignTakeoffProperty.Proj, BridgeAssignTakeoffProperty.Proj.ToString()),
                new RKwd((int) BridgeAssignTakeoffProperty.Id, BridgeAssignTakeoffProperty.Id.ToString()),
                new RKwd((int) BridgeAssignTakeoffProperty.Typ, BridgeAssignTakeoffProperty.Typ.ToString()),
                new RKwd((int) BridgeAssignTakeoffProperty.RfId, BridgeAssignTakeoffProperty.RfId.ToString()),
                new RKwd((int) BridgeAssignTakeoffProperty.Desc, BridgeAssignTakeoffProperty.Desc.ToString())
            });

        public static RKwdMap BridgeAssignmentTakeoffObjectKeywordArrayOld = new RKwdMap(new[]
            {
                new RKwd((int) BridgeAssignTakeoffProperty.SId, "TkoSystemId"),
                new RKwd((int) BridgeAssignTakeoffProperty.Proj, "TkoProjectId"),
                new RKwd((int) BridgeAssignTakeoffProperty.Id, "TkoId"),
                new RKwd((int) BridgeAssignTakeoffProperty.Typ, "TkoTypeId"),
                new RKwd((int) BridgeAssignTakeoffProperty.RfId, "TkoRefId"),
                new RKwd((int) BridgeAssignTakeoffProperty.Desc, "Desc")
            });

        public static RKwdMap BridgeEstimateKeywordArray = new RKwdMap(new[]
            {
                new RKwd((int) BridgeEstimateProperty.SId, BridgeEstimateProperty.SId.ToString()),
                new RKwd((int) BridgeEstimateProperty.Est, BridgeEstimateProperty.Est.ToString())
            });

        public static RKwdMap BridgeEstimateKeywordArrayOld = new RKwdMap(new[]
            {
                new RKwd((int) BridgeEstimateProperty.SId, "EstSystemId"),
                new RKwd((int) BridgeEstimateProperty.Est, "Estimate")
            });

        public static RKwdMap BridgePreferenceKeywordArray = new RKwdMap(new[]
            {
                new RKwd((int) BridgePreferenceProperty.BId, BridgePreferenceProperty.BId.ToString()),
                new RKwd((int) BridgePreferenceProperty.Usr, BridgePreferenceProperty.Usr.ToString()),
                new RKwd((int) BridgePreferenceProperty.Key, BridgePreferenceProperty.Key.ToString()),
                new RKwd((int) BridgePreferenceProperty.Val, BridgePreferenceProperty.Val.ToString())
            });

        public static RKwdMap BridgePreferenceKeywordArrayOld = new RKwdMap(new[]
            {
                new RKwd((int) BridgePreferenceProperty.BId, "BridgeId"),
                new RKwd((int) BridgePreferenceProperty.Usr, "UserId"),
                new RKwd((int) BridgePreferenceProperty.Key, "PreferenceKey"),
                new RKwd((int) BridgePreferenceProperty.Val, "PreferenceValue")
            });

        public static RKwdMap BridgeTakeoffProjectKeywordArray = new RKwdMap(new[]
            {
                new RKwd((int) BridgeTakeoffProjectProperty.SId, BridgeTakeoffProjectProperty.SId.ToString()),
                new RKwd((int) BridgeTakeoffProjectProperty.Id,
                         BridgeTakeoffProjectProperty.Id.ToString()),
                new RKwd((int) BridgeTakeoffProjectProperty.Name,
                         BridgeTakeoffProjectProperty.Name.ToString()),
                new RKwd((int) BridgeTakeoffProjectProperty.Proj,
                         BridgeTakeoffProjectProperty.Proj.ToString())
            });

        public static RKwdMap BridgeTakeoffProjectKeywordArrayOld = new RKwdMap(new[]
            {
                new RKwd((int) BridgeTakeoffProjectProperty.SId, "TkoSystemId"),
                new RKwd((int) BridgeTakeoffProjectProperty.Id,
                         "TkoProjectId"),
                new RKwd((int) BridgeTakeoffProjectProperty.Name,
                         "TkoProjectName"),
                new RKwd((int) BridgeTakeoffProjectProperty.Proj,
                         "TakeoffProject")
            });

        public static RKwdMap VariableAssignmentKeywordArray = new RKwdMap(new[]
            {
                new RKwd((int) BridgeAssignVariableAssignProperty.Tko,
                         BridgeAssignVariableAssignProperty.Tko.ToString()),
                new RKwd((int) BridgeAssignVariableAssignProperty.FVar,
                         BridgeAssignVariableAssignProperty.FVar.ToString()),
                new RKwd((int) BridgeAssignVariableAssignProperty.TVar,
                         BridgeAssignVariableAssignProperty.TVar.ToString()),
                new RKwd((int) BridgeAssignVariableAssignProperty.Val,
                         BridgeAssignVariableAssignProperty.Val.ToString()),
                new RKwd((int) BridgeAssignVariableAssignProperty.FOVal,
                         BridgeAssignVariableAssignProperty.FOVal.ToString()),
                new RKwd((int) BridgeAssignVariableAssignProperty.TOVal,
                         BridgeAssignVariableAssignProperty.TOVal.ToString()),
                new RKwd((int) BridgeAssignVariableAssignProperty.DfVal,
                         BridgeAssignVariableAssignProperty.DfVal.ToString()),
                new RKwd((int) BridgeAssignVariableAssignProperty.HasFV,
                         BridgeAssignVariableAssignProperty.HasFV.ToString()),
                new RKwd((int) BridgeAssignVariableAssignProperty.MTko,
                         BridgeAssignVariableAssignProperty.MTko.ToString())
            });

        public static RKwdMap VariableAssignmentKeywordArrayOld = new RKwdMap(new[]
            {
                new RKwd((int) BridgeAssignVariableAssignProperty.Tko,
                         "FromTakeoffNumber"),
                new RKwd((int) BridgeAssignVariableAssignProperty.FVar,
                         "FromVariableName"),
                new RKwd((int) BridgeAssignVariableAssignProperty.TVar,
                         "ToVariableName"),
                new RKwd((int) BridgeAssignVariableAssignProperty.Val,
                         "VariableValue"),
                new RKwd((int) BridgeAssignVariableAssignProperty.FOVal,
                         "FromOverrideValue"),
                new RKwd((int) BridgeAssignVariableAssignProperty.TOVal,
                         "ToOverrideValue")
            });

        public static RKwdMap AssignmentHistoryCatalogKeywordArray = new RKwdMap(new[]
           {
                new RKwd((int) AssignmentHistoryCatalogProperty.Id, AssignmentHistoryCatalogProperty.Id.ToString()),
                new RKwd((int) AssignmentHistoryCatalogProperty.Name, AssignmentHistoryCatalogProperty.Name.ToString()),
                new RKwd((int) AssignmentHistoryCatalogProperty.Nts, AssignmentHistoryCatalogProperty.Nts.ToString())
            });


        public static RKwdMap BridgeKeywordArray = new RKwdMap(new[]
            {
                new RKwd((int) BridgeProperty.Id, BridgeProperty.Id.ToString()),
                new RKwd((int) BridgeProperty.BId, BridgeProperty.BId.ToString()),
                new RKwd((int) BridgeProperty.Est, BridgeProperty.Est.ToString()),
                new RKwd((int) BridgeProperty.TPrj, BridgeProperty.TPrj.ToString()),
                new RKwd((int) BridgeProperty.Name, BridgeProperty.Name.ToString()),
                new RKwd((int) BridgeProperty.BkPth, BridgeProperty.BkPth.ToString()),
                new RKwd((int) BridgeProperty.ABkOn, BridgeProperty.ABkOn.ToString()),
                new RKwd((int) BridgeProperty.BkDte, BridgeProperty.BkDte.ToString()),
                new RKwd((int) BridgeProperty.Nts, BridgeProperty.Nts.ToString()),
                new RKwd((int) BridgeProperty.CrBy, BridgeProperty.CrBy.ToString()),
                new RKwd((int) BridgeProperty.CrOn, BridgeProperty.CrOn.ToString()),
                new RKwd((int) BridgeProperty.LAsn, BridgeProperty.LAsn.ToString()),
                new RKwd((int) BridgeProperty.AhId, BridgeProperty.AhId.ToString())
            });

        public static RKwdMap BridgeKeywordArrayOld = new RKwdMap(new[]
            {
                new RKwd((int) BridgeProperty.Id, "Id"),
                new RKwd((int) BridgeProperty.BId, "BridgeId"),
                new RKwd((int) BridgeProperty.Est, "Estimate"),
                new RKwd((int) BridgeProperty.TPrj, "TkoProject"),
                new RKwd((int) BridgeProperty.Name, "Name"),
                new RKwd((int) BridgeProperty.BkPth, "BackupFolderPath"),
                new RKwd((int) BridgeProperty.ABkOn, "AutoBackupEnabled"),
                new RKwd((int) BridgeProperty.BkDte, "LastBackupProcessedOn"),
                new RKwd((int) BridgeProperty.Nts, "Notes"),
                new RKwd((int) BridgeProperty.CrBy, "CreatedBy"),
                new RKwd((int) BridgeProperty.CrOn, "CreatedOn"),
                new RKwd((int) BridgeProperty.LAsn, "LastAssignmentId")
            });

        public static RKwdMap ItemDetailColumnPrefKeywordArray = new RKwdMap(new[]
            {
                new RKwd((int) ItemDetailColumnPrefProperty.Name, ItemDetailColumnPrefProperty.Name.ToString()),
                  new RKwd((int) ItemDetailColumnPrefProperty.Val, ItemDetailColumnPrefProperty.Val.ToString())
            });

        public static RKwdMap ItemDetailPrefKeywordArray = new RKwdMap(new[]
            {
                new RKwd((int) ItemDetailPrefProperty.ClPref, ItemDetailPrefProperty.ClPref.ToString())
            });

    }

    #region Enums

    [Flags]
    public enum ResourceType
    {
        None = 0,
        Item = 2,
        Assembly = 4,
        ETakeoffBridgeAssembly = 8,
    }

    public enum AssignmentHistoryTable
    {
        AssignmentHistoryCatalogIdField = 0,
        EstSystemIdField = 1,
        EstResourceTypeField = 2,
        EstResourceIdField = 3,
        TkoSystemIdField = 4,
        TkoObjectTypeField = 5,
        DataField = 6
    };

    public enum BridgeAssignmentTable
    {
        BridgeIdField = 0,
        AssignmentIdField = 1,
        DataField = 2
    };

    public enum BridgePreferenceTable
    {
        BridgeIdField = 0,
        UserIdField = 1,
        PreferenceKeyField = 2,
        PreferenceDataField = 3
    };

    public enum BridgeTable
    {
        BridgeIdField = 0,
        LastIdField = 1,
        DataField = 2
    };

    public enum AssignmentHistoryCatalogTable
    {
        AssignmentHistoryCatalogIdField = 0,
        DataField = 1
    };

    public enum DbVersionTable
    {
        Version = 0
    };

    public enum FieldSingleTable
    {
        SingleDummyField = 0,
        SingleLastIdField = 1
    };

    public enum GuidTable
    {
        GuidField = 0,
        TypeField = 1,
        RecIdField = 2
    };

    public enum Tables
    {
        BridgeIdSingle = 0,
        Guid = 1,
        Bridge = 2,
        BridgeAssignment = 3,
        BridgePreference = 4,
        AssignmentHistory = 5,
        AssignmentHistoryCatalog = 6,
        DbVersion = 7
    };

    public enum DataType
    {
        String,
        Integer,
        Blob
    };

    public enum AssignEstItemProperty
    {
        Id = 0,
        Asgn = 1,
        ITb = 2 //item table name
    }

    public enum AssignmentProperty
    {
        // ReSharper disable InconsistentNaming
        TSId = 0,
        // ReSharper restore InconsistentNaming
        // ReSharper disable InconsistentNaming
        ESId = 1,
        // ReSharper restore InconsistentNaming
        // ReSharper disable InconsistentNaming
        TTyp = 2,
        // ReSharper restore InconsistentNaming
        RId = 3,
        RTyp = 4,
        RDes = 5,
        Asgn = 6,
        Item = 7,
        Type = 8,
        ItmH = 9,
        AhId = 10
    }

    public enum BridgeAssignmentProperty
    {
        BId = 0,
        AsnId,
        Tko,
        Res,
        ResourceType,
        Pass,
        Item,
        LTko,
        Id,
        ECxt,
        CDel,
        AH
    };

    public enum BridgeAssignEstItemProperty
    {
        Id = 0,
        Qty = 1,
        Desc = 2,
        Asn = 3,
        Idx
    };

    public enum BridgeAssignPassProperty
    {
        PTko = 0,
        STko = 1,
        Asn = 2,
        Id = 3
    }

    public enum BridgeAssignResourceProperty
    {
        Id = 0,
        Typ,
        Desc
    }

    public enum BridgeAssignTakeoffProperty
    {
        SId = 0,
        Proj,
        Id,
        Typ,
        RfId,
        Desc
    }

    public enum BridgeEstimateProperty
    {
        SId,
        Est,
    }

    public enum BridgePreferenceProperty
    {
        BId = 0,
        Usr = 1,
        Key = 2,
        Val = 3
    }

    public enum BridgeTakeoffProjectProperty
    {
        SId,
        Id,
        Name,
        Proj
    }

    public enum BridgeAssignVariableAssignProperty
    {
        Tko = 0,
        FVar = 1,
        TVar = 2,
        Val = 3,
        FOVal = 4,
        TOVal = 5,
        DfVal = 6,
        HasFV = 7,
        MTko = 8
    }

    public enum AssignmentHistoryCatalogProperty
    {
        Id = 0,
        Name,
        Nts
    }

    public enum BridgeProperty
    {
        Id = 0,
        BId,
        Est,
        // ReSharper disable InconsistentNaming
        TPrj,
        // ReSharper restore InconsistentNaming
        Name,
        BkPth,
        ABkOn,
        LAsn,
        BkDte,
        Nts,
        CrBy,
        CrOn,
        AhId
    }

    public enum ItemDetailColumnPrefProperty
    {
        Name = 0,
        Val = 2
    }

    public enum ItemDetailPrefProperty
    {
        ClPref = 0
    };

    #endregion
}
