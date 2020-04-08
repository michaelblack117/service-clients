# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class TenantExtendedInformationContract(Model):
    """Extended tenant information.

    :param issuer_did: Issuer DID
    :type issuer_did: str
    :param issuer_key: Issuer Public Key
    :type issuer_key: str
    :param issuer_key_generation_seed: Isuser key generation seed used for
     deterministic key creation (32 characters)
    :type issuer_key_generation_seed: str
    :param agent_did: Agent DID
    :type agent_did: str
    :param agent_key: Agent Public Key
    :type agent_key: str
    :param agent_key_generation_seed: Agent key generation seed used for
     deterministic key creation (32 characters)
    :type agent_key_generation_seed: str
    :param agent_service_endpoint: Agent service endpoint URL
    :type agent_service_endpoint: str
    :param transaction_endorsement: Possible values include: 'Shared',
     'Dedicated', 'Delegated'
    :type transaction_endorsement: str or ~agency.models.enum
    """

    _attribute_map = {
        'issuer_did': {'key': 'issuerDid', 'type': 'str'},
        'issuer_key': {'key': 'issuerKey', 'type': 'str'},
        'issuer_key_generation_seed': {'key': 'issuerKeyGenerationSeed', 'type': 'str'},
        'agent_did': {'key': 'agentDid', 'type': 'str'},
        'agent_key': {'key': 'agentKey', 'type': 'str'},
        'agent_key_generation_seed': {'key': 'agentKeyGenerationSeed', 'type': 'str'},
        'agent_service_endpoint': {'key': 'agentServiceEndpoint', 'type': 'str'},
        'transaction_endorsement': {'key': 'transactionEndorsement', 'type': 'str'},
    }

    def __init__(self, *, issuer_did: str=None, issuer_key: str=None, issuer_key_generation_seed: str=None, agent_did: str=None, agent_key: str=None, agent_key_generation_seed: str=None, agent_service_endpoint: str=None, transaction_endorsement=None, **kwargs) -> None:
        super(TenantExtendedInformationContract, self).__init__(**kwargs)
        self.issuer_did = issuer_did
        self.issuer_key = issuer_key
        self.issuer_key_generation_seed = issuer_key_generation_seed
        self.agent_did = agent_did
        self.agent_key = agent_key
        self.agent_key_generation_seed = agent_key_generation_seed
        self.agent_service_endpoint = agent_service_endpoint
        self.transaction_endorsement = transaction_endorsement
