# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class VerificationParameters(Model):
    """Create verification.

    All required parameters must be populated in order to send to Azure.

    :param verification_definition_id: Required. Verification definition
     identifier.
    :type verification_definition_id: str
    :param connection_id: Connection identifier.
    :type connection_id: str
    """

    _validation = {
        'verification_definition_id': {'required': True},
    }

    _attribute_map = {
        'verification_definition_id': {'key': 'verificationDefinitionId', 'type': 'str'},
        'connection_id': {'key': 'connectionId', 'type': 'str'},
    }

    def __init__(self, **kwargs):
        super(VerificationParameters, self).__init__(**kwargs)
        self.verification_definition_id = kwargs.get('verification_definition_id', None)
        self.connection_id = kwargs.get('connection_id', None)
