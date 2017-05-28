module.exports = function (grunt) {
	grunt.initConfig({
		watch: {
			coffee: {
				files: ['dev/scripts/*.coffee'],
				tasks: ['coffee'],
				options: {
					livereload: true
				}
			},
			jade: {
			    files: ['dev/*.jade'],
			    tasks: ['jade'],
			    options: {
			        livereload: true
			    }
			},
			styles: {
				files: ['dev/styles/*.styl'],
				tasks: ['stylus'],
				options: {
					livereload: true
				}
			},
			livereload: {
				options: {
					livereload: '<%= connect.options.livereload %>'
				},
				files: [
					'dev/*.html',
					'dev/**/*.css',
					'dev/**/*.js'
				]
			}
		},
		connect: {
			options: {
				port: 9578,
				livereload: 35729,
				hostname: 'localhost'
			},
			livereload: {
				options: {
					open: true,
					base: [
						'dev'
					]
				}
			}
		},
		jshint: {
			all: ['Gruntfile.js', 'app/scripts/*.js']
		},
		csslint: {
		    strict: {
		        options: {
		            import: 2
		        },
		        src: ['app/styles/*.css']
		    },
		    lax: {
		        options: {
		            import: false
		        },
		        src: ['app/styles/*.css']
		    }
		},
		stylus: {
			compile: {
				files: {
				    'app/styles/main.css': ['dev/styles/main.styl', 'dev/styles/styl.styl']
				}
			}
		},
		cssmin: {
		    target: {
		        files: [{
		            expand: true,
		            cwd: 'app/styles',
		            src: ['*.css', '!*.min.css'],
		            dest: 'dist/styles',
		            ext: '.min.css'
		        }]
		    }
		},
		coffee: {
            compile: {
                options: {
                    bare: true
                },
                files: {
                    'app/scripts/simple.js': ['dev/scripts/simple.coffee', 'dev/scripts/main.coffee']
                }
            }
		},
		uglify: {
		    my_target: {
		        files: {
		            'dist/scripts/output.min.js': ['app/scripts/simple.js', 'app/scripts/main.js']
		        }
		    }
		},
		jade: {
		    compile: {
		        options: {
		            data: {
		                debug: false
		            }
		        },
				files: {
					'app/index.html': ['dev/index.jade']
				}
			}
		},
		htmlmin: {                                     
		    dist: {                                     
		        options: {                                
		            removeComments: true,
		            collapseWhitespace: true
		        },
		        files: {                                   
		            'dist/index.html': 'app/index.html'    
		        }
		    }
		},
		copy: {
		    copyDev: {
		        expand: true,
		        cwd: 'dev/images/',
		        src: '**',
		        dest: 'app/images/',
		        flatten: true,
		        filter: 'isFile',
		    },
		    copyDist: {
		        expand: true,
		        cwd: 'dev/images/',
		        src: '**',
		        dest: 'dist/images/',
		        flatten: true,
		        filter: 'isFile',
		    }
		}
	});
	
	grunt.loadNpmTasks('grunt-contrib-coffee');
	grunt.loadNpmTasks('grunt-contrib-jshint');
	grunt.loadNpmTasks('grunt-contrib-uglify');
	grunt.loadNpmTasks('grunt-contrib-csslint');
	grunt.loadNpmTasks('grunt-contrib-stylus');
	grunt.loadNpmTasks('grunt-contrib-cssmin');
	grunt.loadNpmTasks('grunt-contrib-jade');
	grunt.loadNpmTasks('grunt-contrib-htmlmin');
	grunt.loadNpmTasks('grunt-contrib-copy');
	grunt.loadNpmTasks('grunt-contrib-connect');
	grunt.loadNpmTasks('grunt-contrib-watch');

	grunt.registerTask('serve', ['coffee', 'jshint', 'stylus', 'jade', 'copy', 'connect', 'watch']);
	grunt.registerTask('build', ['coffee', 'jshint', 'csslint', 'stylus', 'jade', 'cssmin', 'uglify', 'htmlmin', 'copy']);
};