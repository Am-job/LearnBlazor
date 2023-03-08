// Manages the registered resize event listeners so they can be disposed later
let windowEventListeners = {};

function AddWindowWidthListener(objReference) {
    let eventListener = () => UpdateWindowWidth(objReference);
    window.addEventListener("resize", eventListener);
    windowEventListeners[objReference] = eventListener;
}

function RemoveWindowWidthListener(objReference) {
    window.removeEventListener("resize", windowEventListeners[objReference]);
}

function UpdateWindowWidth(objReference) {
    objReference.invokeMethodAsync("UpdateWindowWidth", window.innerWidth);
}

function GetInitalWidthJS(objReference) {
    objReference.invokeMethodAsync("GetInitalWidthCS", window.innerWidth);
}
