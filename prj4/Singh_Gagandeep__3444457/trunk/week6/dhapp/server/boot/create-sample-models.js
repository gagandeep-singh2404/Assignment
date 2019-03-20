// create-sample-models.js
module.exports = function(app) {
 var ds = app.dataSources.gaganSQL;
 var dbTables = ['Employee'];
 ds.automigrate(dbTables, function(err) {
 if (err) throw err;
 });
};
