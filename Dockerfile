# Use an official PostgreSQL image as the base image
FROM postgres:latest
 
# Set environment variables for PostgreSQL
ENV POSTGRES_DB=BDCardBrand
ENV POSTGRES_USER=ojimenez
ENV POSTGRES_PASSWORD=ojimenez.
 
# Copy the SQL script to initialize the database
# COPY init.sql /docker-entrypoint-initdb.d/