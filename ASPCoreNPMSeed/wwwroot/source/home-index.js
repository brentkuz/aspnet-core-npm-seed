
console.log("home-index.js is loaded");

//get config
var configRaw = $("#config").html();
if (configRaw) {
    var config = JSON.parse(configRaw);
    console.log(config);
}