// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Security.Attestation
{
    /// <summary> A Microsoft Azure Attestation response token body - the body of a response token issued by MAA. </summary>
    public partial class AttestationResult
    {
        /// <summary> Initializes a new instance of AttestationResult. </summary>
        /// <param name="internalJti"> Unique Identifier for the token. </param>
        /// <param name="internalIss"> The Principal who issued the token. </param>
        /// <param name="internalIat"> The time at which the token was issued, in the number of seconds since 1970-01-0T00:00:00Z UTC. </param>
        /// <param name="internalExp"> The expiration time after which the token is no longer valid, in the number of seconds since 1970-01-0T00:00:00Z UTC. </param>
        /// <param name="internalNbf"> The not before time before which the token cannot be considered valid, in the number of seconds since 1970-01-0T00:00:00Z UTC. </param>
        /// <param name="internalCnf"> An RFC 7800 Proof of Possession Key. </param>
        /// <param name="nonce"> The Nonce input to the attestation request, if provided. </param>
        /// <param name="version"> The Schema version of this structure. Current Value: 1.0. </param>
        /// <param name="runtimeClaims"> Runtime Claims. </param>
        /// <param name="inittimeClaims"> Inittime Claims. </param>
        /// <param name="policyClaims"> Policy Generated Claims. </param>
        /// <param name="verifierType"> The Attestation type being attested. </param>
        /// <param name="internalPolicySigner"> The certificate used to sign the policy object, if specified. </param>
        /// <param name="internalPolicyHash"> The SHA256 hash of the BASE64URL encoded policy text used for attestation. </param>
        /// <param name="isDebuggable"> True if the enclave is debuggable, false otherwise. </param>
        /// <param name="productId"> The SGX Product ID for the enclave. </param>
        /// <param name="mrEnclave"> The HEX encoded SGX MRENCLAVE value for the enclave. </param>
        /// <param name="mrSigner"> The HEX encoded SGX MRSIGNER value for the enclave. </param>
        /// <param name="svn"> The SGX SVN value for the enclave. </param>
        /// <param name="internalEnclaveHeldData"> A copy of the RuntimeData specified as an input to the attest call. </param>
        /// <param name="sgxCollateral"> The SGX SVN value for the enclave. </param>
        /// <param name="internalDeprecatedVersion"> DEPRECATED: Private Preview version of x-ms-ver claim. </param>
        /// <param name="internalDeprecatedIsDebuggable"> DEPRECATED: Private Preview version of x-ms-sgx-is-debuggable claim. </param>
        /// <param name="internalDeprecatedSgxCollateral"> DEPRECATED: Private Preview version of x-ms-sgx-collateral claim. </param>
        /// <param name="internalDeprecatedEnclaveHeldData"> DEPRECATED: Private Preview version of x-ms-sgx-ehd claim. </param>
        /// <param name="internalDeprecatedEnclaveHeldData2"> DEPRECATED: Private Preview version of x-ms-sgx-ehd claim. </param>
        /// <param name="internalDeprecatedProductId"> DEPRECATED: Private Preview version of x-ms-sgx-product-id. </param>
        /// <param name="internalDeprecatedMrEnclave"> DEPRECATED: Private Preview version of x-ms-sgx-mrenclave. </param>
        /// <param name="internalDeprecatedMrSigner"> DEPRECATED: Private Preview version of x-ms-sgx-mrsigner. </param>
        /// <param name="internalDeprecatedSvn"> DEPRECATED: Private Preview version of x-ms-sgx-svn. </param>
        /// <param name="internalDeprecatedTee"> DEPRECATED: Private Preview version of x-ms-tee. </param>
        /// <param name="internalDeprecatedPolicySigner"> DEPRECATED: Private Preview version of x-ms-policy-signer. </param>
        /// <param name="internalDeprecatedPolicyHash"> DEPRECATED: Private Preview version of x-ms-policy-hash. </param>
        /// <param name="internalDeprecatedRpData"> DEPRECATED: Private Preview version of nonce. </param>
        internal AttestationResult(string internalJti, string internalIss, double? internalIat, double? internalExp, double? internalNbf, object internalCnf, string nonce, string version, object runtimeClaims, object inittimeClaims, object policyClaims, string verifierType, JsonWebKey internalPolicySigner, string internalPolicyHash, bool? isDebuggable, float? productId, string mrEnclave, string mrSigner, float? svn, string internalEnclaveHeldData, object sgxCollateral, string internalDeprecatedVersion, bool? internalDeprecatedIsDebuggable, object internalDeprecatedSgxCollateral, string internalDeprecatedEnclaveHeldData, string internalDeprecatedEnclaveHeldData2, float? internalDeprecatedProductId, string internalDeprecatedMrEnclave, string internalDeprecatedMrSigner, float? internalDeprecatedSvn, string internalDeprecatedTee, JsonWebKey internalDeprecatedPolicySigner, string internalDeprecatedPolicyHash, string internalDeprecatedRpData)
        {
            InternalJti = internalJti;
            InternalIss = internalIss;
            InternalIat = internalIat;
            InternalExp = internalExp;
            InternalNbf = internalNbf;
            InternalCnf = internalCnf;
            Nonce = nonce;
            Version = version;
            RuntimeClaims = runtimeClaims;
            InittimeClaims = inittimeClaims;
            PolicyClaims = policyClaims;
            VerifierType = verifierType;
            InternalPolicySigner = internalPolicySigner;
            InternalPolicyHash = internalPolicyHash;
            IsDebuggable = isDebuggable;
            ProductId = productId;
            MrEnclave = mrEnclave;
            MrSigner = mrSigner;
            Svn = svn;
            InternalEnclaveHeldData = internalEnclaveHeldData;
            SgxCollateral = sgxCollateral;
            InternalDeprecatedVersion = internalDeprecatedVersion;
            InternalDeprecatedIsDebuggable = internalDeprecatedIsDebuggable;
            InternalDeprecatedSgxCollateral = internalDeprecatedSgxCollateral;
            InternalDeprecatedEnclaveHeldData = internalDeprecatedEnclaveHeldData;
            InternalDeprecatedEnclaveHeldData2 = internalDeprecatedEnclaveHeldData2;
            InternalDeprecatedProductId = internalDeprecatedProductId;
            InternalDeprecatedMrEnclave = internalDeprecatedMrEnclave;
            InternalDeprecatedMrSigner = internalDeprecatedMrSigner;
            InternalDeprecatedSvn = internalDeprecatedSvn;
            InternalDeprecatedTee = internalDeprecatedTee;
            InternalDeprecatedPolicySigner = internalDeprecatedPolicySigner;
            InternalDeprecatedPolicyHash = internalDeprecatedPolicyHash;
            InternalDeprecatedRpData = internalDeprecatedRpData;
        }
        /// <summary> The Nonce input to the attestation request, if provided. </summary>
        public string Nonce { get; }
        /// <summary> The Schema version of this structure. Current Value: 1.0. </summary>
        public string Version { get; }
        /// <summary> Runtime Claims. </summary>
        public object RuntimeClaims { get; }
        /// <summary> Inittime Claims. </summary>
        public object InittimeClaims { get; }
        /// <summary> Policy Generated Claims. </summary>
        public object PolicyClaims { get; }
        /// <summary> The Attestation type being attested. </summary>
        public string VerifierType { get; }
        /// <summary> True if the enclave is debuggable, false otherwise. </summary>
        public bool? IsDebuggable { get; }
        /// <summary> The SGX Product ID for the enclave. </summary>
        public float? ProductId { get; }
        /// <summary> The HEX encoded SGX MRENCLAVE value for the enclave. </summary>
        public string MrEnclave { get; }
        /// <summary> The HEX encoded SGX MRSIGNER value for the enclave. </summary>
        public string MrSigner { get; }
        /// <summary> The SGX SVN value for the enclave. </summary>
        public float? Svn { get; }
        /// <summary> The SGX SVN value for the enclave. </summary>
        public object SgxCollateral { get; }
    }
}
