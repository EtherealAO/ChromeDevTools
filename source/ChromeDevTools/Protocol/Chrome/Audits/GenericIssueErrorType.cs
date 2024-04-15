using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GenericIssueErrorType
	{
			CrossOriginPortalPostMessageError,
			FormLabelForNameError,
			FormDuplicateIdForInputError,
			FormInputWithNoLabelError,
			FormAutocompleteAttributeEmptyError,
			FormEmptyIdAndNameAttributesForInputError,
			FormAriaLabelledByToNonExistingId,
			FormInputAssignedAutocompleteValueToIdOrNameAttributeError,
			FormLabelHasNeitherForNorNestedInput,
			FormLabelForMatchesNonExistingIdError,
			FormInputHasWrongButWellIntendedAutocompleteValueError,
	}
}
