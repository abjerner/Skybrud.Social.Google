module.exports = function(grunt) {

	var path = require('path');

	// Load the package JSON file
	var pkg = grunt.file.readJSON('package.json');

	// get the root path of the project
	var projectRoot = 'src/' + pkg.name + '/';

	// Load information about the assembly
	var assembly = grunt.file.readJSON(projectRoot + 'Properties/AssemblyInfo.json');

	// Get the version of the package
	var version = assembly.informationalVersion ? assembly.informationalVersion : assembly.version;

	grunt.initConfig({
		pkg: pkg,
		zip: {
			release: {
				router: function (filepath) {
					return path.basename(filepath);
				},
				src: [
					'src/' + pkg.name + '/bin/Release/Skybrud.Social.Core.dll',
					'src/' + pkg.name + '/bin/Release/Skybrud.Social.Core.xml',
					'src/' + pkg.name + '/bin/Release/' + pkg.name + '.dll',
					'src/' + pkg.name + '/bin/Release/' + pkg.name + '.xml',
					'src/' + pkg.name + '/LICENSE.txt'
				],
				dest: 'releases/github/' + pkg.name + '.v' + version + '.zip'
			}
		},
		nugetpack: {
			release: {
				src: 'src/' + pkg.name + '/' + pkg.name + '.csproj',
				dest: 'releases/nuget/'
			}
		}
	});

	grunt.loadNpmTasks('grunt-nuget');
	grunt.loadNpmTasks('grunt-zip');

	grunt.registerTask('dev', ['zip', 'nugetpack']);

	grunt.registerTask('default', ['dev']);

};