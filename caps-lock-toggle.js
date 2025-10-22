const editor = this.app.workspace.activeEditor?.editor;
if (!editor) return '';

const selectedText = editor.getSelection();
if (!selectedText) return '';

if (selectedText === selectedText.toUpperCase()) {
    return selectedText.toLowerCase();
} else if (selectedText === selectedText.toLowerCase()) {
    return selectedText.charAt(0).toUpperCase() + selectedText.slice(1).toLowerCase();
} else {
    return selectedText.toUpperCase();
}
