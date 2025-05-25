using AdapterPattern;

var videoEditor = new VideoEditor(new Video());
videoEditor.ApplyColor(new BlackAndWhiteColor());

var videoEditorWithAdapter = new VideoEditor(new Video());
videoEditorWithAdapter.ApplyColor(new RainbowColor(new RainbowThirdParty()));

