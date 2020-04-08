# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class CredentialDefinitionParameters(Model):
    """Credential definition parameters.

    :param support_revocation: Support credential revocation
    :type support_revocation: bool
    :param tag: Unique tag to differentiate definitions of the same schema
    :type tag: str
    """

    _attribute_map = {
        'support_revocation': {'key': 'supportRevocation', 'type': 'bool'},
        'tag': {'key': 'tag', 'type': 'str'},
    }

    def __init__(self, *, support_revocation: bool=None, tag: str=None, **kwargs) -> None:
        super(CredentialDefinitionParameters, self).__init__(**kwargs)
        self.support_revocation = support_revocation
        self.tag = tag
