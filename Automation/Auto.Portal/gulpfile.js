/// <binding AfterBuild='copyfiles' />
/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp'),
    open = require("gulp-open");
//rimraf = require("rimraf"),
//concat = require("gulp-concat"),
//cssmin = require("gulp-cssmin"),
//open = require("gulp-open"),
//uglify = require("gulp-uglify");

var Server = require('karma').Server;

gulp.task('copyfiles', function () {
    gulp.src("./node_modules/angular/*").pipe(gulp.dest("./wwwroot/lib/angular"));
    gulp.src("./node_modules/angular-mocks/*").pipe(gulp.dest("./wwwroot/lib/angular-mocks"));
    gulp.src("./node_modules/bootstrap/**").pipe(gulp.dest("./wwwroot/lib/bootstrap"));
    gulp.src("./node_modules/jquery/**").pipe(gulp.dest("./wwwroot/lib/jquery"));
    gulp.src("./node_modules/jquery-validation/**").pipe(gulp.dest("./wwwroot/lib/jquery-validation"));
    gulp.src("./node_modules/jquery-validation-unobtrusive/*").pipe(gulp.dest("./wwwroot/lib/jquery-validation-unobtrusive"));
});
gulp.task('test', function (done) {
    new Server({
        configFile: __dirname + '/karma.conf.js',
        singleRun: true
    }, done).start();
});
gulp.task('tdd', function (done) {
    new Server({
        configFile: __dirname + '/karma.conf.js',
    }, done).start();
});
gulp.task('open', function () {
    gulp.src("./tests/units.html")
    .pipe(open());
});
gulp.task('default', ['copyfiles', 'test', 'open']);