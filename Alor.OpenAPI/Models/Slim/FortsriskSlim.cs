﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using SpanJson;

namespace Alor.OpenAPI.Models.Slim
{
    [DataContract]
    public sealed class FortsriskSlim : IEquatable<FortsriskSlim>, IValidatableObject
    {
        public FortsriskSlim() { }

        /// <include file='../../XmlDocs/CoreModels.xml' path='Docs/Members[@name="responseFortsRisk"]/Member[@name="responseFortsRisk"]/*' />
        public FortsriskSlim(string? portfolio = default, decimal? moneyFree = default,
            decimal? moneyBlocked = default, decimal? fee = default, decimal? moneyOld = default,
            decimal? moneyAmount = default, decimal? moneyPledgeAmount = default, decimal? vmInterCl = default,
            decimal? vmCurrentPositions = default, bool? isLimitsSet = default,
            decimal? indicativeVarMargin = default, decimal? netOptionValue = default, decimal? posRisk = default)
        {
            Portfolio = portfolio;
            MoneyFree = moneyFree;
            MoneyBlocked = moneyBlocked;
            Fee = fee;
            MoneyOld = moneyOld;
            MoneyAmount = moneyAmount;
            MoneyPledgeAmount = moneyPledgeAmount;
            VmInterCl = vmInterCl;
            VmCurrentPositions = vmCurrentPositions;
            IsLimitsSet = isLimitsSet;
            IndicativeVarMargin = indicativeVarMargin;
            NetOptionValue = netOptionValue;
            PosRisk = posRisk;
        }

        /// <include file='../../XmlDocs/CoreModels.xml' path='Docs/Members[@name="responseFortsRisk"]/Member[@name="portfolio"]/*' />
        [DataMember(Name = "p", EmitDefaultValue = false)]
        public string? Portfolio { get; init; }

        /// <include file='../../XmlDocs/CoreModels.xml' path='Docs/Members[@name="responseFortsRisk"]/Member[@name="moneyFree"]/*' />
        [DataMember(Name = "f", EmitDefaultValue = false)]
        public decimal? MoneyFree { get; init; }

        /// <include file='../../XmlDocs/CoreModels.xml' path='Docs/Members[@name="responseFortsRisk"]/Member[@name="moneyBlocked"]/*' />
        [DataMember(Name = "b", EmitDefaultValue = false)]
        public decimal? MoneyBlocked { get; init; }

        /// <include file='../../XmlDocs/CoreModels.xml' path='Docs/Members[@name="responseFortsRisk"]/Member[@name="fee"]/*' />
        [DataMember(Name = "fee", EmitDefaultValue = false)]
        public decimal? Fee { get; init; }

        /// <include file='../../XmlDocs/CoreModels.xml' path='Docs/Members[@name="responseFortsRisk"]/Member[@name="moneyOld"]/*' />
        [DataMember(Name = "o", EmitDefaultValue = false)]
        public decimal? MoneyOld { get; init; }

        /// <include file='../../XmlDocs/CoreModels.xml' path='Docs/Members[@name="responseFortsRisk"]/Member[@name="moneyAmount"]/*' />
        [DataMember(Name = "a", EmitDefaultValue = false)]
        public decimal? MoneyAmount { get; init; }

        /// <include file='../../XmlDocs/CoreModels.xml' path='Docs/Members[@name="responseFortsRisk"]/Member[@name="moneyPledgeAmount"]/*' />
        [DataMember(Name = "pa", EmitDefaultValue = false)]
        public decimal? MoneyPledgeAmount { get; init; }

        /// <include file='../../XmlDocs/CoreModels.xml' path='Docs/Members[@name="responseFortsRisk"]/Member[@name="vmInterCl"]/*' />
        [DataMember(Name = "mgc", EmitDefaultValue = false)]
        public decimal? VmInterCl { get; init; }

        /// <include file='../../XmlDocs/CoreModels.xml' path='Docs/Members[@name="responseFortsRisk"]/Member[@name="vmCurrentPositions"]/*' />
        [DataMember(Name = "mgp", EmitDefaultValue = false)]
        public decimal? VmCurrentPositions { get; init; }

        /// <include file='../../XmlDocs/CoreModels.xml' path='Docs/Members[@name="responseFortsRisk"]/Member[@name="isLimitsSet"]/*' />
        [DataMember(Name = "lim", EmitDefaultValue = false)]
        public bool? IsLimitsSet { get; init; }

        /// <include file='../../XmlDocs/CoreModels.xml' path='Docs/Members[@name="responseFortsRisk"]/Member[@name="indicativeVarMargin"]/*' />
        [DataMember(Name = "ivm", EmitDefaultValue = false)]
        public decimal? IndicativeVarMargin { get; init; }

        /// <include file='../../XmlDocs/CoreModels.xml' path='Docs/Members[@name="responseFortsRisk"]/Member[@name="netOptionValue"]/*' />
        [DataMember(Name = "nov", EmitDefaultValue = false)]
        public decimal? NetOptionValue { get; init; }

        /// <include file='../../XmlDocs/CoreModels.xml' path='Docs/Members[@name="responseFortsRisk"]/Member[@name="posRisk"]/*' />
        [DataMember(Name = "pr", EmitDefaultValue = false)]
        public decimal? PosRisk { get; init; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FortsriskSlim {").Append(Environment.NewLine);
            sb.Append("  Portfolio: ").Append(Portfolio).Append(Environment.NewLine);
            sb.Append("  MoneyFree: ").Append(MoneyFree).Append(Environment.NewLine);
            sb.Append("  MoneyBlocked: ").Append(MoneyBlocked).Append(Environment.NewLine);
            sb.Append("  Fee: ").Append(Fee).Append(Environment.NewLine);
            sb.Append("  MoneyOld: ").Append(MoneyOld).Append(Environment.NewLine);
            sb.Append("  MoneyAmount: ").Append(MoneyAmount).Append(Environment.NewLine);
            sb.Append("  MoneyPledgeAmount: ").Append(MoneyPledgeAmount).Append(Environment.NewLine);
            sb.Append("  VmInterCl: ").Append(VmInterCl).Append(Environment.NewLine);
            sb.Append("  VmCurrentPositions: ").Append(VmCurrentPositions).Append(Environment.NewLine);
            sb.Append("  IsLimitsSet: ").Append(IsLimitsSet).Append(Environment.NewLine);
            sb.Append("  IndicativeVarMargin: ").Append(IndicativeVarMargin).Append(Environment.NewLine);
            sb.Append("  NetOptionValue: ").Append(NetOptionValue).Append(Environment.NewLine);
            sb.Append("  PosRisk: ").Append(PosRisk).Append(Environment.NewLine);
            sb.Append('}').Append(Environment.NewLine);
            return sb.ToString();
        }

        public string ToJson() => Encoding.UTF8.GetString(JsonSerializer.Generic.Utf8.Serialize(this));

        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(Portfolio);
            hash.Add(MoneyFree);
            hash.Add(MoneyBlocked);
            hash.Add(Fee);
            hash.Add(MoneyOld);
            hash.Add(MoneyAmount);
            hash.Add(MoneyPledgeAmount);
            hash.Add(VmInterCl);
            hash.Add(VmCurrentPositions);
            hash.Add(IsLimitsSet);
            hash.Add(IndicativeVarMargin);
            hash.Add(NetOptionValue);
            hash.Add(PosRisk);
            return hash.ToHashCode();
        }

        private static bool EqualsHelper(FortsriskSlim? first, FortsriskSlim? second) =>
            first?.Portfolio == second?.Portfolio &&
            first?.MoneyFree == second?.MoneyFree &&
            first?.MoneyBlocked == second?.MoneyBlocked &&
            first?.Fee == second?.Fee &&
            first?.MoneyOld == second?.MoneyOld &&
            first?.MoneyAmount == second?.MoneyAmount &&
            first?.MoneyPledgeAmount == second?.MoneyPledgeAmount &&
            first?.VmInterCl == second?.VmInterCl &&
            first?.VmCurrentPositions == second?.VmCurrentPositions &&
            first?.IsLimitsSet == second?.IsLimitsSet &&
            first?.IndicativeVarMargin == second?.IndicativeVarMargin &&
            first?.NetOptionValue == second?.NetOptionValue &&
            first?.PosRisk == second?.PosRisk;

        public bool Equals(FortsriskSlim? other)
        {
            if (this == (object?)other)
                return true;

            if ((object?)other == null)
                return false;

            return GetType() == other.GetType() && EqualsHelper(this, other);
        }

        public override bool Equals(object? obj) => Equals(obj as FortsriskSlim);

        private static bool Equals(FortsriskSlim? first, FortsriskSlim? second) =>
            first?.Equals(second) ?? first == (object?)second;

        public static bool operator ==(FortsriskSlim? first, FortsriskSlim? second) => Equals(first, second);

        public static bool operator !=(FortsriskSlim? first, FortsriskSlim? second) => !Equals(first, second);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
