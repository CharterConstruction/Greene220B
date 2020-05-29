var gulp = require('gulp');
var pretty = require('@awea/gulp-pretty-html');
var fileinclude = require('gulp-file-include');
var sass = require('gulp-sass');
var postcss = require('gulp-postcss');
var autoprefixer = require('autoprefixer');
var concat = require('gulp-concat');
var rename = require('gulp-rename');

var path = {
  html: {
    entry: [
      'src/**/*.html'
    ],
    watch: [
      'src/**/*.html',
      'lib/**/*.html',
    ],
    output: 'build/'
  },
  scss: {
    theme: {
      entry: 'lib/scss/elements.scss',
      watch: [
        'lib/scss/elements.scss',
        'lib/scss/**/*.scss'
      ],
      output: 'lib/css/'
    },
    components: {
      entry: 'lib/components/**/*.scss',
      watch: 'lib/components/**/*.scss',
      output: 'lib/components/'
    }
  }
}

function buildHtml() {
  return gulp.src(path.html.entry)
    .pipe(fileinclude({ prefix: '@' }))
    .pipe(pretty({}))
    .pipe(gulp.dest(path.html.output));
}

function buildTheme() {
  return gulp.src(path.scss.theme.entry)
    .pipe(sass({
      importer: require('node-sass-tilde-importer'),
      includePaths: [ './node_modules' ],
      outputStyle: 'expanded'
    }))
    .pipe(postcss([ autoprefixer() ]))
    .pipe(rename('elements.theme.css'))
    .pipe(gulp.dest(path.scss.theme.output));
}

function buildComponents() {
  return gulp.src(path.scss.components.entry)
    .pipe(sass({
      importer: require('node-sass-tilde-importer'),
      includePaths: [ './node_modules' ],
      outputStyle: 'expanded'
    }))
    .pipe(postcss([ autoprefixer() ]))
    .pipe(gulp.dest(path.scss.components.output))
    .pipe(concat('elements.components.css'))
    .pipe(gulp.dest(path.scss.components.output))
}

function watch() {
  build();
  gulp.watch(path.html.watch, buildHtml);
  gulp.watch(path.scss.theme.watch, buildTheme);
  gulp.watch(path.scss.components.watch, buildComponents);
}

function build() {
  return gulp.parallel(buildHtml, buildTheme, buildComponents)
}

exports.html = buildHtml();
exports.watch = watch;
exports.build = build();
exports.default = build();
