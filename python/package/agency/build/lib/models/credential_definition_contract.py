# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class CredentialDefinitionContract(Model):
    """CredentialDefinitionContract.

    :param name:
    :type name: str
    :param version:
    :type version: str
    :param attributes:
    :type attributes: list[str]
    :param supports_revocation:
    :type supports_revocation: bool
    :param max_credential_count:
    :type max_credential_count: int
    :param schema_id:
    :type schema_id: str
    :param definition_id:
    :type definition_id: str
    """

    _attribute_map = {
        'name': {'key': 'name', 'type': 'str'},
        'version': {'key': 'version', 'type': 'str'},
        'attributes': {'key': 'attributes', 'type': '[str]'},
        'supports_revocation': {'key': 'supportsRevocation', 'type': 'bool'},
        'max_credential_count': {'key': 'maxCredentialCount', 'type': 'int'},
        'schema_id': {'key': 'schemaId', 'type': 'str'},
        'definition_id': {'key': 'definitionId', 'type': 'str'},
    }

    def __init__(self, **kwargs):
        super(CredentialDefinitionContract, self).__init__(**kwargs)
        self.name = kwargs.get('name', None)
        self.version = kwargs.get('version', None)
        self.attributes = kwargs.get('attributes', None)
        self.supports_revocation = kwargs.get('supports_revocation', None)
        self.max_credential_count = kwargs.get('max_credential_count', None)
        self.schema_id = kwargs.get('schema_id', None)
        self.definition_id = kwargs.get('definition_id', None)