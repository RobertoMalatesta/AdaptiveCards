<!-- AUTO-GENERATED: This section is auto-generated from schemas/adaptive-card.json. Do NOT add anything above this or edit anything inside, it MUST be the first thing in the document and will be overwritten. -->

# Input.Toggle

| Property | Type | Required | Description | Version |
| -------- | ---- | -------- | ----------- | ------- |
| **type** | `"Input.Toggle"` | Yes | Must be `"Input.Toggle"`. | 1.0 |
| **title** | `string` | Yes | Title for the toggle | 1.0 |
| **id** | `string` | Yes | Unique identifier for the value. Used to identify collected input when the Submit action is performed. | 1.0 |
| **value** | `string` | No, default: `"false"` | The initial selected value. If you want the toggle to be initially on, set this to the value of `valueOn`'s value. | 1.0 |
| **valueOff** | `string` | No, default: `"false"` | The value when toggle is off | 1.0 |
| **valueOn** | `string` | No, default: `"true"` | The value when toggle is on | 1.0 |
| **wrap** | `boolean` | No | If `true`, allow text to wrap. Otherwise, text is clipped. | 1.2 |

**Inherited properties**

| Property | Type | Required | Description | Version |
| -------- | ---- | -------- | ----------- | ------- |
| **errorMessage** | `string` | No | Error message to display when entered input is invalid | 1.3 |
| **isRequired** | `boolean` | No | Whether or not this input is required | 1.3 |
| **label** | `string`, `TextBlock`, `RichTextBlock` | No | Label for this input | 1.3 |
| **fallback** | `Element`, `FallbackOption` | No | Describes what to do when an unknown element is encountered or the requires of this or any children can't be met. | 1.2 |
| **height** | `BlockElementHeight` | No | Specifies the height of the element. | 1.1 |
| **separator** | `boolean` | No | When `true`, draw a separating line at the top of the element. | 1.0 |
| **spacing** | `Spacing` | No | Controls the amount of spacing between this element and the preceding element. | 1.0 |
| **isVisible** | `boolean` | No, default: `true` | If `false`, this item will be removed from the visual tree. | 1.2 |
| **requires** | `Dictionary<string>` | No | A series of key/value pairs indicating features that the item requires with corresponding minimum version. When a feature is missing or of insufficient version, fallback is triggered. | 1.2 |


## label

Label for this input

* **Type**: `string`, `TextBlock`, `RichTextBlock`
* **Version** : 1.3
* **Required**: No
* **Allowed values**:
  * `string`
  * `TextBlock`
  * `RichTextBlock`


## fallback

Describes what to do when an unknown element is encountered or the requires of this or any children can't be met.

* **Type**: `Element`, `FallbackOption`
* **Version** : 1.2
* **Required**: No
* **Allowed values**:
  * `ActionSet`
  * `ColumnSet`
  * `Container`
  * `FactSet`
  * `Image`
  * `ImageSet`
  * `Input.ChoiceSet`
  * `Input.Date`
  * `Input.Number`
  * `Input.Text`
  * `Input.Time`
  * `Input.Toggle`
  * `Media`
  * `RichTextBlock`
  * `TextBlock`
  * `"drop"`: Causes this element to be dropped immediately when unknown elements are encountered. The unknown element doesn't bubble up any higher.


## height

Specifies the height of the element.

* **Type**: `BlockElementHeight`
* **Version** : 1.1
* **Required**: No
* **Allowed values**:
  * `"auto"`: The height of the container will be determined by the height of its contents.
  * `"stretch"`: The container will stretch its height to the available remaining height of the parent container.


## spacing

Controls the amount of spacing between this element and the preceding element.

* **Type**: `Spacing`
* **Required**: No
* **Allowed values**:
  * `"default"`
  * `"none"`
  * `"small"`
  * `"medium"`
  * `"large"`
  * `"extraLarge"`
  * `"padding"`
<!-- END AUTO-GENERATED -->

## Rendering

### Labels
The `label` property should be rendered to the left of the toggle box. Clicking/tapping on the rendered label should toggle the input.

### Accessibility
The `label` property should be set as the accessibility text when present. If the `label` property is not present, the `placeholder` property should be used instead if present.

### Input Validation
 If the input has `isRequired` true, and the card has `showRequiredInputHints`, the input should be marked with a * in the host's `attention` color. The * should be placed on the label in the case where the label is set, and otherwise be placed next to the title string.
 
 The `isRequired` property should be validated for this input type.The validation should take place as follows:
 
 - Validate the input when it loses focus for the first time.
 - Once the field has been marked invalid, validate when the user click the toggle so they can see that is has become valid.

 If the input does not pass validation, it should be outlined in the host's `attention` color, and the `errorMessage` should be displayed below the input.