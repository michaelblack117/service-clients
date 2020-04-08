# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class AttributeFilter(Model):
    """AttributeFilter.

    :param schema_id:
    :type schema_id: str
    :param schema_issuer_did:
    :type schema_issuer_did: str
    :param schema_name:
    :type schema_name: str
    :param schema_version:
    :type schema_version: str
    :param issuer_did:
    :type issuer_did: str
    :param credential_definition_id:
    :type credential_definition_id: str
    """

    _attribute_map = {
        'schema_id': {'key': 'schemaId', 'type': 'str'},
        'schema_issuer_did': {'key': 'schemaIssuerDid', 'type': 'str'},
        'schema_name': {'key': 'schemaName', 'type': 'str'},
        'schema_version': {'key': 'schemaVersion', 'type': 'str'},
        'issuer_did': {'key': 'issuerDid', 'type': 'str'},
        'credential_definition_id': {'key': 'credentialDefinitionId', 'type': 'str'},
    }

    def __init__(self, **kwargs):
        super(AttributeFilter, self).__init__(**kwargs)
        self.schema_id = kwargs.get('schema_id', None)
        self.schema_issuer_did = kwargs.get('schema_issuer_did', None)
        self.schema_name = kwargs.get('schema_name', None)
        self.schema_version = kwargs.get('schema_version', None)
        self.issuer_did = kwargs.get('issuer_did', None)
        self.credential_definition_id = kwargs.get('credential_definition_id', None)
