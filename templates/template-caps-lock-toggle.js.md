{% const selectedText = await utils.getSelectedText() %}
{% if selectedText %}
{% const isAllUpper = selectedText === selectedText.toUpperCase() %}
{% const isAllLower = selectedText === selectedText.toLowerCase() %}
{% const isTitleCase = selectedText === selectedText.charAt(0).toUpperCase() + selectedText.slice(1).toLowerCase() %}

{% let newText %}
{% if isAllUpper %}
    {% newText = selectedText.toLowerCase() %}
{% elseif isAllLower %}
    {% newText = selectedText.charAt(0).toUpperCase() + selectedText.slice(1).toLowerCase() %}
{% else %}
    {% newText = selectedText.toUpperCase() %}
{% endif %}

{{newText}}
{% endif %}